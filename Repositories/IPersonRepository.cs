using Assesment.Models;

namespace Assesment.Repositories;

public interface IPersonRepository
{
    Task Create (Person model);
    Task<Person> GetById (int id);
    Task<List<Person>> GetAll();
}