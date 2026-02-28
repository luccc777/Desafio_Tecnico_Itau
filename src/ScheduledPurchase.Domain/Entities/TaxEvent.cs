using ScheduledPurchase.Domain.Enums;

namespace ScheduledPurchase.Domain.Entities;

public class TaxEvent
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public TaxEventType Type { get; set; }
    public string? Ticker { get; set; }
    public decimal BaseAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public bool PublishedToKafka { get; set; }
    public DateTime EventDate { get; set; }

    public Client? Client { get; set; }
}
