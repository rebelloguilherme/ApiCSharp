using ControleDeDespesas.Domain.Models;

namespace ControleDeDespesas.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPeopleAsync();
        Task<Person> GetByIdAsync(Guid id);
        Task<Person> CreateAsync(Person person);
        Task<Person> UpdateAsync(Person person);
        Task<Person> DeleteAsync(Person person);
    }
}