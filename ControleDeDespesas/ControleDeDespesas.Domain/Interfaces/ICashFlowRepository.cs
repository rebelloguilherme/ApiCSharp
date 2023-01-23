using ControleDeDespesas.Domain.Models;

namespace ControleDeDespesas.Domain.Interfaces
{
    public interface ICashFlowRepository
    {
        Task<IEnumerable<CashFlow>> GetCashFlowsAsync();
        Task<CashFlow> GetByIdAsync(Guid id);
        Task<CashFlow> CreateAsync(CashFlow cashFlow);
        Task<CashFlow> UpdateAsync(CashFlow cashFlow);
        Task<CashFlow> DeleteAsync(CashFlow cashFlow);
    }
}
