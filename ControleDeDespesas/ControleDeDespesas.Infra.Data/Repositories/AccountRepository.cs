using ControleDeDespesas.Domain.Interfaces;
using ControleDeDespesas.Domain.Models;
using ControleDeDespesas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleDeDespesas.Infra.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private ApplicationDbContext _accountContext;

        public AccountRepository(ApplicationDbContext accountContext)
        {
            _accountContext = accountContext;
        }

        public async Task<Account> CreateAsync(Account account)
        {
            try
            {
                _accountContext.Add(account);
                await _accountContext.SaveChangesAsync();
                return account;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Account> DeleteAsync(Account account)
        {
            try
            {
                _accountContext.Remove(account);
                await _accountContext.SaveChangesAsync();
                return account;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
            try
            {
                return await _accountContext.Accounts.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Account> GetByIdAsync(Guid id)
        {
            try
            {
                return await _accountContext.Accounts.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Account> UpdateAsync(Account account)
        {
            try
            {
                _accountContext.Update(account);
                await _accountContext.SaveChangesAsync();
                return account;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}