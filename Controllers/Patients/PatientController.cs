using Assesment.Repositories;
using AutoMapper;
using HotelManagementAndReservation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientController : GeneralController
{
    protected readonly IPatientRepository _patientRepository;

    public PatientController(IMapper mapper, IPatientRepository patientRepository) : base(mapper)
    {
        _patientRepository = patientRepository;
    }

    public PatientController(IPatientRepository appointmentRepository)
    {
        _patientRepository = appointmentRepository;
    }
}
