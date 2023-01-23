using ControleDeDespesas.Domain.Interfaces;
using ControleDeDespesas.Domain.Models;
using ControleDeDespesas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleDeDespesas.Infra.Data.Repositories
{
    public class CashFlowRepository : ICashFlowRepository
    {
        private ApplicationDbContext _cashFlowContext;

        public CashFlowRepository(ApplicationDbContext cashFlowContext)
        {
            _cashFlowContext = cashFlowContext;
        }

        public async Task<CashFlow> CreateAsync(CashFlow cashFlow)
        {
            try
            {
                _cashFlowContext.Add(cashFlow);
                await _cashFlowContext.SaveChangesAsync();
                return cashFlow;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CashFlow> DeleteAsync(CashFlow cashFlow)
        {
            try
            {
                _cashFlowContext.Remove(cashFlow);
                await _cashFlowContext.SaveChangesAsync();
                return cashFlow;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<CashFlow>> GetCashFlowsAsync()
        {
            try
            {
                return await _cashFlowContext.CashFlows.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CashFlow> GetByIdAsync(Guid id)
        {
            try
            {
                return await _cashFlowContext.CashFlows.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CashFlow> UpdateAsync(CashFlow cashFlow)
        {
            try
            {
                _cashFlowContext.Update(cashFlow);
                await _cashFlowContext.SaveChangesAsync();
                return cashFlow;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }



}