using Assesment.Data;
using Assesment.Models;
using Assesment.Repositories;
using HotelManagementAndReservation.Services;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Services;

public class DoctorService(AppDbContext appDbContext) : GeneralService(appDbContext), IDoctorRepository
{
    public async Task Create(Doctor model)
    {
        try
        {
            await _context.Doctors.AddAsync(model);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear el doctor.", ex);
        }
    }

    public async Task<Doctor> GetById(int id)
    {
        try
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                throw new Exception("Doctor no encontrado.");
            }

            return doctor;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener el doctor.", ex);
        }
    }
}
