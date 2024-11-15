using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assesment.Controllers.Persons
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonGetController(IPersonRepository appointmentRepository) : PersonController(appointmentRepository)
    {
        [HttpGet("GetById/{id}")]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
        Summary = "Get a person by ID",
        Description = "Retrieves the details of a specific person based on their ID."
    )]
        [ProducesResponseType(typeof(Person), 200)] // OK
        [ProducesResponseType(typeof(ProblemDetails), 404)] // Not Found
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        public async Task<ActionResult<Person>> GetById(int id)
        {
            try
            {
                var person = await _personRepository.GetById(id);
                if (person == null)
                {
                    return NotFound(new ProblemDetails
                    {
                        Title = "Person not found",
                        Detail = $"No person found with ID {id}."
                    });
                }

                return Ok(person);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error retrieving person",
                    Detail = ex.Message
                });
            }
        }

        [HttpGet("GetAll")]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get all persons",
            Description = "Retrieves a list of all persons."
        )]
        [ProducesResponseType(typeof(List<Person>), 200)] // OK
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        public async Task<ActionResult<List<Person>>> GetAll()
        {
            try
            {
                var persons = await _personRepository.GetAll();
                return Ok(persons);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error retrieving persons",
                    Detail = ex.Message
                });
            }
        }
    }
}