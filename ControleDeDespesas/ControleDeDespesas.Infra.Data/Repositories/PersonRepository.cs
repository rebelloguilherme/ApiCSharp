using ControleDeDespesas.Domain.Interfaces;
using ControleDeDespesas.Domain.Models;
using ControleDeDespesas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleDeDespesas.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private ApplicationDbContext _personContext;

        public PersonRepository(ApplicationDbContext personContext)
        {
            _personContext = personContext;
        }

        public async Task<Person> CreateAsync(Person person)
        {
            try
            {
                _personContext.Add(person);
                await _personContext.SaveChangesAsync();
                return person;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Person> DeleteAsync(Person person)
        {
            try
            {
                _personContext.Remove(person);
                await _personContext.SaveChangesAsync();
                return person;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            try
            {
                return await _personContext.Persons.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Person> GetByIdAsync(Guid id)
        {
            try
            {
                return await _personContext.Persons.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Person> UpdateAsync(Person person)
        {
            try
            {
                _personContext.Update(person);
                await _personContext.SaveChangesAsync();
                return person;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }



}