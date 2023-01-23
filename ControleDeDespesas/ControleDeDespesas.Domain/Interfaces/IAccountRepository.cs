using ControleDeDespesas.Domain.Models;

namespace ControleDeDespesas.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAccountsAsync();
        Task<Account> GetByIdAsync(Guid id);
        Task<Account> CreateAsync(Account account);
        Task<Account> UpdateAsync(Account account);
        Task<Account> DeleteAsync(Account account);
    }
}
