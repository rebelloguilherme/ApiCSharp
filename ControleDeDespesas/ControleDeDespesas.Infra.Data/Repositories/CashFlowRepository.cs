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
            _cashFlowContext.Add(cashFlow);
            await _cashFlowContext.SaveChangesAsync();
            return cashFlow;
        }

        public async Task<CashFlow> DeleteAsync(CashFlow cashFlow)
        {
            _cashFlowContext.Remove(cashFlow);
            await _cashFlowContext.SaveChangesAsync();
            return cashFlow;
        }

        public async Task<IEnumerable<CashFlow>> GetCashFlowsAsync()
        {
            return await _cashFlowContext.CashFlows.ToListAsync();
        }

        public async Task<CashFlow> GetByIdAsync(Guid id)
        {
            return await _cashFlowContext.CashFlows.FindAsync(id);
        }

        public async Task<CashFlow> UpdateAsync(CashFlow cashFlow)
        {

            _cashFlowContext.Update(cashFlow);
            await _cashFlowContext.SaveChangesAsync();
            return cashFlow;
        }
    }
}