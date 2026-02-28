using ScheduledPurchase.Domain.Enums;

namespace ScheduledPurchase.Domain.Entities;

public class PurchaseOrder
{
    public long Id { get; set; }
    public long MasterAccountId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public MarketType MarketType { get; set; }
    public DateTime ExecutedAt { get; set; }
    public DateOnly ReferenceDate { get; set; }

    public Account? MasterAccount { get; set; }
    public List<Distribution> Distributions { get; set; } = new();
}
