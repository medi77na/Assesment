using Assesment.Models;

namespace Assesment.Repositories;

public interface IPatientRepository
{
    Task Create (Patient model);
    Task Add(Patient model);
    Task Delete(Patient model);
    Task<Patient> GetByDocument(int document);
    Task<List<Patient>> GetAll();

}
/*
- **GET /patients/{id}/appointments**: Obtener el historial de citas de un paciente específico.
*/