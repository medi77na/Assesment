using Assesment.Models;
using Assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assesment.Controllers.Patients
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientDeleteController(IPatientRepository appointmentRepository) : PatientController(appointmentRepository)
    {
        [HttpDelete]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
        Summary = "Delete a patient record",
        Description = "Deletes an existing patient record from the system."
    )]
        [ProducesResponseType(204)] // No Content
        [ProducesResponseType(typeof(ProblemDetails), 400)] // Bad Request
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        [ProducesResponseType(typeof(ProblemDetails), 404)] // Not Found
        public async Task<IActionResult> Delete([FromBody] Patient model)
        {
            if (model == null || model.Id <= 0)
            {
                return BadRequest(new ProblemDetails
                {
                    Title = "Invalid patient data",
                    Detail = "The patient information provided is invalid."
                });
            }

            try
            {
                var existingPatient = await _patientRepository.GetByDocument(model.Id);
                if (existingPatient == null)
                {
                    return NotFound(new ProblemDetails
                    {
                        Title = "Patient not found",
                        Detail = $"No patient found with ID {model.Id}."
                    });
                }

                await _patientRepository.Delete(model);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error deleting patient",
                    Detail = ex.Message
                });
            }
        }
    }
}