using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface IBasketRepository
{
    Task<RecommendationBasket?> GetActiveAsync();
    Task<List<RecommendationBasket>> GetAllAsync();
    Task AddAsync(RecommendationBasket basket);
    void Update(RecommendationBasket basket);
    Task SaveChangesAsync();
}
