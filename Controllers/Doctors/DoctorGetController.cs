using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assesment.Controllers.Doctors;

[ApiController]
[Route("api/[controller]")]
public class DoctorGetController(IDoctorRepository doctorRepository) : DoctorController(doctorRepository)
{
    [HttpGet("{id:int}")]
    //\[Authorize\] // Requires authentication to access this endpoint
    [SwaggerOperation(
       Summary = "Get doctor by ID",
       Description = "Retrieves detailed information about a doctor using their unique identifier."
   )]
    [ProducesResponseType(typeof(Doctor), 200)] // Success response
    [ProducesResponseType(typeof(ProblemDetails), 404)] // Doctor not found
    [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
    public async Task<ActionResult<Doctor>> GetById(int id)
    {
        try
        {
            var doctor = await _doctorRepository.GetById(id);

            if (doctor == null)
            {
                return NotFound(new ProblemDetails
                {
                    Title = "Doctor not found",
                    Detail = $"No doctor found with ID {id}."
                });
            }
            return Ok(doctor);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ProblemDetails
            {
                Title = "Error retrieving doctor",
                Detail = ex.Message
            });
        }
    }
}