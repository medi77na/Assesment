using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assesment.Controllers.Patients
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientGetController(IPatientRepository appointmentRepository) : PatientController(appointmentRepository)
    {
        [HttpGet("GetAll")]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
       Summary = "Get all patients",
       Description = "Retrieves a list of all registered patients."
   )]
        [ProducesResponseType(typeof(List<Patient>), 200)] // OK
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        [ProducesResponseType(typeof(ProblemDetails), 500)] // Internal Server Error
        public async Task<ActionResult<List<Patient>>> GetAll()
        {
            try
            {
                var patients = await _patientRepository.GetAll();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error retrieving patients",
                    Detail = ex.Message
                });
            }
        }

        [HttpGet("GetByDocument/{document:int}")]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get patient by document",
            Description = "Retrieves a specific patient by their document number."
        )]
        [ProducesResponseType(typeof(Patient), 200)] // OK
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        [ProducesResponseType(typeof(ProblemDetails), 404)] // Not Found
        [ProducesResponseType(typeof(ProblemDetails), 500)] // Internal Server Error
        public async Task<ActionResult<Patient>> GetByDocument(int document)
        {
            try
            {
                var patient = await _patientRepository.GetByDocument(document);
                if (patient == null)
                {
                    return NotFound(new ProblemDetails
                    {
                        Title = "Patient not found",
                        Detail = $"No patient found with document number {document}."
                    });
                }
                return Ok(patient);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error retrieving patient",
                    Detail = ex.Message
                });
            }
        }
    }
}