using Assesment.Data;
using Assesment.Models;
using Assesment.Repositories;
using HotelManagementAndReservation.Services;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Services;

public class PersonService(AppDbContext appDbContext) : GeneralService(appDbContext), IPersonRepository
{
    public async Task Create(Person model)
    {
        try
        {
            await _context.Persons.AddAsync(model);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear la persona.", ex);
        }
    }

    public async Task<List<Person>> GetAll()
    {
        try
        {
            var persons = await _context.Persons.ToListAsync();
            return persons;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener la lista de personas.", ex);
        }
    }

    public async Task<Person> GetById(int id)
    {
        try
        {
            var person = await _context.Persons
                                        .FirstOrDefaultAsync(p => p.Id == id);

            if (person == null)
            {
                throw new Exception("Persona no encontrada con ese ID.");
            }

            return person;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener la persona por ID.", ex);
        }
    }
}
