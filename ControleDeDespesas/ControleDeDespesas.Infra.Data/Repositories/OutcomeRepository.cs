using ControleDeDespesas.Domain.Interfaces;
using ControleDeDespesas.Domain.Models;
using ControleDeDespesas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleDeDespesas.Infra.Data.Repositories
{
    public class OutcomeRepository : IOutcomeRepository
    {
        private ApplicationDbContext _outcomeContext;

        public OutcomeRepository(ApplicationDbContext outcomeContext)
        {
            _outcomeContext = outcomeContext;
        }

        public async Task<Outcome> CreateAsync(Outcome account)
        {
            try
            {
                _outcomeContext.Add(account);
                await _outcomeContext.SaveChangesAsync();
                return account;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Outcome> DeleteAsync(Outcome outcome)
        {
            try
            {
                _outcomeContext.Remove(outcome);
                await _outcomeContext.SaveChangesAsync();
                return outcome;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Outcome>> GetOutcomesAsync()
        {
            try
            {
                return await _outcomeContext.Outcomes.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Outcome> GetByIdAsync(Guid id)
        {
            try
            {
                return await _outcomeContext.Outcomes.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Outcome> UpdateAsync(Outcome outcome)
        {
            try
            {
                _outcomeContext.Update(outcome);
                await _outcomeContext.SaveChangesAsync();
                return outcome;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }



}