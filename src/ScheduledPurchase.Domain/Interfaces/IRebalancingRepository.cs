using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface IRebalancingRepository
{
    Task AddRangeAsync(List<Rebalancing> rebalancings);
    Task SaveChangesAsync();
}
