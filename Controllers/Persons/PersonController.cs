using Assesment.Repositories;
using AutoMapper;
using HotelManagementAndReservation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : GeneralController
{
    protected readonly IPersonRepository _personRepository;

    public PersonController(IMapper mapper, IPersonRepository personRepository) : base(mapper)
    {
        _personRepository = personRepository;
    }

    public PersonController(IPersonRepository appointmentRepository)
    {
        _personRepository = appointmentRepository;
    }

}
