using ControleDeDespesas.Domain.Interfaces;
using ControleDeDespesas.Domain.Models;
using ControleDeDespesas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleDeDespesas.Infra.Data.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private ApplicationDbContext _incomeContext;

        public IncomeRepository(ApplicationDbContext incomeContext)
        {
            _incomeContext = incomeContext;
        }

        public async Task<Income> CreateAsync(Income income)
        {
            try
            {
                _incomeContext.Add(income);
                await _incomeContext.SaveChangesAsync();
                return income;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Income> DeleteAsync(Income income)
        {
            try
            {
                _incomeContext.Remove(income);
                await _incomeContext.SaveChangesAsync();
                return income;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Income>> GetIncomesAsync()
        {
            try
            {
                return await _incomeContext.Incomes.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Income> GetByIdAsync(Guid id)
        {
            try
            {
                return await _incomeContext.Incomes.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Income> UpdateAsync(Income income)
        {
            try
            {
                _incomeContext.Update(income);
                await _incomeContext.SaveChangesAsync();
                return income;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }



}