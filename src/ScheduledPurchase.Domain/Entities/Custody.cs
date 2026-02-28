namespace ScheduledPurchase.Domain.Entities;

public class Custody
{
    public long Id { get; set; }
    public long AccountId { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal AveragePrice { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Account? Account { get; set; }
}
