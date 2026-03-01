using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class DistributionRepository : IDistributionRepository
{
    private readonly AppDbContext _context;

    public DistributionRepository(AppDbContext context) => _context = context;

    public async Task AddRangeAsync(List<Distribution> distributions) =>
        await _context.Distributions.AddRangeAsync(distributions);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
