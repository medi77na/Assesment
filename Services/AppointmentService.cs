using Assesment.Data;
using Assesment.Models;
using Assesment.Repositories;
using HotelManagementAndReservation.Services;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Services;

public class AppointmentService(AppDbContext appDbContext) : GeneralService(appDbContext), IAppointmentRepository
{
    public async Task Create(Appointment model)
    {
        try
        {
            await _context.Appointments.AddAsync(model);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear la cita.", ex);
        }
    }


    public async Task<List<Appointment>> GetAll()
    {
        try
        {
            return await _context.Appointments.ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener las citas.", ex);
        }
    }

    public async Task<Appointment> GetById(int id)
    {
        try
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                throw new Exception("Cita no encontrada.");
            }

            return appointment;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener la cita.", ex);
        }
    }

    public async Task<List<Appointment>> GetByIdDoctor(int doctorId)
    {
        try
        {
            return await _context.Appointments
                                 .Where(a => a.IdDoctor == doctorId)
                                 .ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener las citas del médico.", ex);
        }
    }

    public async Task<List<Appointment>> GetByIdPatient(int patientId)
    {
        try
        {
            return await _context.Appointments
                                 .Where(a => a.IdPatient == patientId)
                                 .ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener las citas del paciente.", ex);
        }
    }
}
