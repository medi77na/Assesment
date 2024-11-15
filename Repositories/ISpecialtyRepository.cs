using Assesment.Models;

namespace Assesment.Repositories;

public interface ISpecialtyRepository
{
    Task<List<Specialty>> GetAll();
}
