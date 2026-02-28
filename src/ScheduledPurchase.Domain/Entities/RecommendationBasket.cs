namespace ScheduledPurchase.Domain.Entities;

public class RecommendationBasket
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Active { get; set; } = true;
    public DateTime CreatedAt { get; set; }
    public DateTime? DeactivatedAt { get; set; }

    public List<BasketItem> Items { get; set; } = new();
}
