using Assesment.Repositories;
using AutoMapper;
using HotelManagementAndReservation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DoctorController : GeneralController
{
    protected readonly IDoctorRepository _doctorRepository;

    public DoctorController(IMapper mapper, IDoctorRepository doctorRepository) : base(mapper)
    {
        _doctorRepository = doctorRepository;
    }

    public DoctorController(IDoctorRepository appointmentRepository)
    {
        _doctorRepository = appointmentRepository;
    }

}
