namespace ScheduledPurchase.Domain.Entities;

public class BasketItem
{
    public long Id { get; set; }
    public long BasketId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public decimal Percentage { get; set; }

    public RecommendationBasket? Basket { get; set; }
}
