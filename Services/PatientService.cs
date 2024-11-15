using Assesment.Data;
using Assesment.Models;
using Assesment.Repositories;
using HotelManagementAndReservation.Services;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Services;

public class PatientService(AppDbContext appDbContext) : GeneralService(appDbContext), IPatientRepository
{

    public async Task Create(Patient model)
    {
        try
        {
            await _context.Patients.AddAsync(model);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear el paciente.", ex);
        }
    }

    public async Task Delete(Patient model)
    {
        try
        {
            _context.Patients.Remove(model);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar el paciente.", ex);
        }
    }

    public async Task<List<Patient>> GetAll()
    {
        try
        {
            var patients = await _context.Patients.ToListAsync();
            return patients;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener la lista de pacientes.", ex);
        }
    }

    public async Task<Patient> GetByDocument(int document)
    {
        try
        {
            var patient = await _context.Patients
                                        .FirstOrDefaultAsync(p => p.Person.DocumentNumber == document);

            if (patient == null)
            {
                throw new Exception("Paciente no encontrado con ese documento.");
            }

            return patient;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener el paciente por documento.", ex);
        }
    }

}