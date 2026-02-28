namespace ScheduledPurchase.Domain.Entities;

public class StockQuote
{
    public long Id { get; set; }
    public DateOnly TradingDate { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public decimal OpenPrice { get; set; }
    public decimal ClosePrice { get; set; }
    public decimal HighPrice { get; set; }
    public decimal LowPrice { get; set; }
}
