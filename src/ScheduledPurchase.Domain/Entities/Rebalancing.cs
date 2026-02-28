using ScheduledPurchase.Domain.Enums;

namespace ScheduledPurchase.Domain.Entities;

public class Rebalancing
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public RebalancingType Type { get; set; }
    public string SoldTicker { get; set; } = string.Empty;
    public string BoughtTicker { get; set; } = string.Empty;
    public int SoldQuantity { get; set; }
    public int BoughtQuantity { get; set; }
    public decimal SaleAmount { get; set; }
    public decimal PurchaseAmount { get; set; }
    public DateTime RebalancedAt { get; set; }

    public Client? Client { get; set; }
}
