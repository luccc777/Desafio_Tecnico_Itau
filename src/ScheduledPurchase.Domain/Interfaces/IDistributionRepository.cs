using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface IDistributionRepository
{
    Task AddRangeAsync(List<Distribution> distributions);
    Task SaveChangesAsync();
}
