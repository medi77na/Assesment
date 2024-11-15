using Assesment.Models;

namespace Assesment.Repositories;

public interface IDoctorRepository
{
    Task Create (Doctor model);
    Task<Doctor> GetById(int id);
}