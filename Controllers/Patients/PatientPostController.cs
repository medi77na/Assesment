using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assesment.Controllers.Patients
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientPostController(IMapper mapper, IPatientRepository patientRepository) : PatientController(mapper, patientRepository)
    {
        [HttpPost("Create")]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
        Summary = "Create a new patient",
        Description = "Creates a new patient record in the system."
    )]
        [ProducesResponseType(typeof(Patient), 201)] // Created
        [ProducesResponseType(typeof(ProblemDetails), 400)] // Bad Request
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        [ProducesResponseType(typeof(ProblemDetails), 500)] // Internal Server Error
        public async Task<ActionResult<Patient>> Create([FromBody] Patient model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ProblemDetails
                {
                    Title = "Invalid model state",
                    Detail = "The provided patient data is invalid."
                });
            }

            try
            {
                await _patientRepository.Create(model);
                return CreatedAtAction(nameof(Create), new { id = model.Id }, model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error creating patient",
                    Detail = ex.Message
                });
            }
        }
    }
}