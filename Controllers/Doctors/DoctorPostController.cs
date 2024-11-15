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

namespace Assesment.Controllers.Doctors
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorPostController(IMapper mapper, IDoctorRepository doctorRepository) : DoctorController(mapper, doctorRepository)
    {
        [HttpPost]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
        Summary = "Create a new doctor",
        Description = "Adds a new doctor to the system."
    )]
        [ProducesResponseType(typeof(Doctor), 201)] // Created response
        [ProducesResponseType(typeof(ProblemDetails), 400)] // Bad Request
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        public async Task<ActionResult<Doctor>> Create([FromBody] Doctor model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ProblemDetails
                {
                    Title = "Invalid doctor data",
                    Detail = "Please ensure all required fields are correctly filled."
                });
            }

            try
            {
                await _doctorRepository.Create(model);
                return CreatedAtAction(nameof(Create), new { id = model.Id }, model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error creating doctor",
                    Detail = ex.Message
                });
            }
        }
    }
}