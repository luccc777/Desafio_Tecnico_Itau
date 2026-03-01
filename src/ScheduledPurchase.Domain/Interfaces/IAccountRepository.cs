using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface IAccountRepository
{
    Task<Account?> GetByIdAsync(long id);
    Task<Account?> GetMasterAccountAsync();
    Task<Account?> GetByClientIdAsync(long clientId);
    Task AddAsync(Account account);
    Task SaveChangesAsync();
}
