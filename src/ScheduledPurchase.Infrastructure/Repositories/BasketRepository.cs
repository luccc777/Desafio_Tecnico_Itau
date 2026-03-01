using Microsoft.EntityFrameworkCore;
using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class BasketRepository : IBasketRepository
{
    private readonly AppDbContext _context;

    public BasketRepository(AppDbContext context) => _context = context;

    public async Task<RecommendationBasket?> GetActiveAsync() =>
        await _context.RecommendationBaskets.Include(b => b.Items)
            .FirstOrDefaultAsync(b => b.Active);

    public async Task<List<RecommendationBasket>> GetAllAsync() =>
        await _context.RecommendationBaskets.Include(b => b.Items)
            .OrderByDescending(b => b.CreatedAt).ToListAsync();

    public async Task AddAsync(RecommendationBasket basket) =>
        await _context.RecommendationBaskets.AddAsync(basket);

    public void Update(RecommendationBasket basket) =>
        _context.RecommendationBaskets.Update(basket);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
