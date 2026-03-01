using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class RebalancingRepository : IRebalancingRepository
{
    private readonly AppDbContext _context;

    public RebalancingRepository(AppDbContext context) => _context = context;

    public async Task AddRangeAsync(List<Rebalancing> rebalancings) =>
        await _context.Rebalancings.AddRangeAsync(rebalancings);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
