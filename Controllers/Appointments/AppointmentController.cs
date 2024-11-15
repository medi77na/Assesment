using Assesment.Repositories;
using AutoMapper;
using HotelManagementAndReservation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : GeneralController
{
    protected readonly IAppointmentRepository _appointmentRepository;

    public AppointmentController(IMapper mapper, IAppointmentRepository appointmentRepository) : base(mapper)
    {
        _appointmentRepository = appointmentRepository;
    }

        public AppointmentController(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }
}
