using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface ITaxEventRepository
{
    Task AddAsync(TaxEvent taxEvent);
    Task AddRangeAsync(List<TaxEvent> taxEvents);
    Task<List<TaxEvent>> GetUnpublishedAsync();
    void Update(TaxEvent taxEvent);
    Task SaveChangesAsync();
}
