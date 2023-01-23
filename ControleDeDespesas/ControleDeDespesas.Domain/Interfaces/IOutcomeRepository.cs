using ControleDeDespesas.Domain.Models;

namespace ControleDeDespesas.Domain.Interfaces
{
    public interface IOutcomeRepository
    {
        Task<IEnumerable<Outcome>> GetOutcomesAsync();
        Task<Outcome> GetByIdAsync(Guid id);
        Task<Outcome> CreateAsync(Outcome outcome);
        Task<Outcome> UpdateAsync(Outcome outcome);
        Task<Outcome> DeleteAsync(Outcome outcome);
    }
}