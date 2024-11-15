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

namespace Assesment.Controllers.Appointments
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentPostController(IMapper mapper, IAppointmentRepository appointmentRepository) : AppointmentController(mapper, appointmentRepository)
    {

        [HttpPost]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
               Summary = "Create a new appointment",
               Description = "Creates a new appointment in the system."
           )]
        [ProducesResponseType(typeof(Appointment), 201)] // Indicates success and resource creation
        [ProducesResponseType(typeof(ProblemDetails), 400)] // Indicates invalid input
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Indicates unauthorized access
        public async Task<ActionResult<Appointment>> Create([FromBody] Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ProblemDetails
                {
                    Title = "Invalid input",
                    Detail = "Please ensure all required fields are correctly filled."
                });
            }

            try
            {
                await _appointmentRepository.Create(appointment);
                return CreatedAtAction(nameof(Create), new { id = appointment.Id }, appointment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error creating appointment",
                    Detail = ex.Message
                });
            }
        }
    }
}