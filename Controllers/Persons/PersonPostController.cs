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

namespace Assesment.Controllers.Persons
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonPostController(IMapper mapper, IPersonRepository personRepository) : PersonController(mapper, personRepository)
    {
        [HttpPost("Create")]
        //\[Authorize\] // Requires authentication to access this endpoint
        [SwaggerOperation(
        Summary = "Create a new person",
        Description = "Creates a new person and adds it to the database."
    )]
        [ProducesResponseType(typeof(Person), 201)] // Created
        [ProducesResponseType(typeof(ProblemDetails), 400)] // Bad Request
        [ProducesResponseType(typeof(ProblemDetails), 401)] // Unauthorized
        public async Task<ActionResult<Person>> Create([FromBody] Person model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ProblemDetails
                {
                    Title = "Invalid input",
                    Detail = "The provided person data is invalid."
                });
            }

            try
            {
                // Optionally map and validate here if the DTO differs from the entity model.
                await _personRepository.Create(model);
                return CreatedAtAction(nameof(Create), new { id = model.Id }, model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ProblemDetails
                {
                    Title = "Error creating person",
                    Detail = ex.Message
                });
            }
        }
    }
}