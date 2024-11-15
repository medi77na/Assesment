using Assesment.Data;
using Assesment.Models;
using Assesment.Repositories;
using HotelManagementAndReservation.Services;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Services;

public class SpecialityService(AppDbContext appDbContext) : GeneralService(appDbContext), ISpecialtyRepository
{
public async Task<List<Specialty>> GetAll()
{
    try
    {
        var specialties = await _context.Specialties.ToListAsync();
        return specialties;
    }
    catch (Exception ex)
    {
        throw new Exception("Error al obtener la lista de especialidades.", ex);
    }
}
}
