using ControleDeDespesas.Domain.Models;

namespace ControleDeDespesas.Domain.Interfaces
{
    public interface IIncomeRepository
    {
        Task<IEnumerable<Income>> GetIncomesAsync();
        Task<Income> GetByIdAsync(Guid id);
        Task<Income> CreateAsync(Income income);
        Task<Income> UpdateAsync(Income income);
        Task<Income> DeleteAsync(Income income);
    }
}
