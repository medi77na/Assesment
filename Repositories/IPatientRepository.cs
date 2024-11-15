using Assesment.Models;

namespace Assesment.Repositories;

public interface IPatientRepository
{
    Task Create (Patient model);
    Task Delete(Patient model);
    Task<Patient> GetByDocument(int document);
    Task<List<Patient>> GetAll();
}