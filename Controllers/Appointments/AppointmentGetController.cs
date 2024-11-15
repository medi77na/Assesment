using Assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Assesment.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Assesment.Controllers.Appointments;

[ApiController]
[Route("api/[controller]")]
public class AppointmentGetController(IAppointmentRepository appointmentRepository) : AppointmentController(appointmentRepository)
{
    [HttpGet]
    //\[Authorize\] // Requires authentication to access this endpoint
    [SwaggerOperation(
        Summary = "Get all appointments",
        Description = "Retrieves a list of all appointments."
    )]
    [ProducesResponseType(typeof(List<Appointment>), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 401)]
    public async Task<ActionResult<List<Appointment>>> GetAll()
    {
        return Ok(await _appointmentRepository.GetAll());
    }

    [HttpGet("{id}")]
    //\[Authorize\] // Requires authentication to access this endpoint
    [SwaggerOperation(
        Summary = "Get appointment by ID",
        Description = "Retrieves the details of a specific appointment by its ID."
    )]
    [ProducesResponseType(typeof(Appointment), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 401)]
    [ProducesResponseType(typeof(ProblemDetails), 404)]
    public async Task<ActionResult<Appointment>> GetById(int id)
    {
        var appointment = await _appointmentRepository.GetById(id);
        if (appointment == null)
        {
            return NotFound(new ProblemDetails
            {
                Title = "Appointment Not Found",
                Detail = $"No appointment found with ID {id}"
            });
        }

        return Ok(appointment);
    }

    [HttpGet("doctor/{id}")]
    //\[Authorize\] // Requires authentication to access this endpoint
    [SwaggerOperation(
        Summary = "Get appointments by doctor ID",
        Description = "Retrieves all appointments associated with a specific doctor by their ID."
    )]
    [ProducesResponseType(typeof(List<Appointment>), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 401)]
    public async Task<ActionResult<List<Appointment>>> GetByIdDoctor(int id)
    {
        return Ok(await _appointmentRepository.GetByIdDoctor(id));
    }

    [HttpGet("patient/{id}")]
    //\[Authorize\] // Requires authentication to access this endpoint
    [SwaggerOperation(
        Summary = "Get appointments by patient ID",
        Description = "Retrieves all appointments associated with a specific patient by their ID."
    )]
    [ProducesResponseType(typeof(List<Appointment>), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 401)]
    public async Task<ActionResult<List<Appointment>>> GetByIdPatient(int id)
    {
        return Ok(await _appointmentRepository.GetByIdPatient(id));
    }
}
