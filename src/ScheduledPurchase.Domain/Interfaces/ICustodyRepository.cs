using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface ICustodyRepository
{
    Task<List<Custody>> GetByAccountIdAsync(long accountId);
    Task<Custody?> GetByAccountAndTickerAsync(long accountId, string ticker);
    Task AddAsync(Custody custody);
    void Update(Custody custody);
    Task SaveChangesAsync();
}
