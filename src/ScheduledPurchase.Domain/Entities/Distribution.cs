namespace ScheduledPurchase.Domain.Entities;

public class Distribution
{
    public long Id { get; set; }
    public long PurchaseOrderId { get; set; }
    public long ChildCustodyId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public DateTime DistributedAt { get; set; }

    public PurchaseOrder? PurchaseOrder { get; set; }
    public Custody? ChildCustody { get; set; }
}
