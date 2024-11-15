using Assesment.Models;

namespace Assesment.Repositories;

public interface IAppointmentRepository
{
    Task<List<Appointment>> GetAll();
    Task<Appointment> GetById(int id);
    Task Create(Appointment appointment);
    Task<List<Appointment>> GetByIdDoctor(int id);
    Task<List<Appointment>> GetByIdPatient(int id);
}