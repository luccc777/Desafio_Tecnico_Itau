using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface IStockQuoteRepository
{
    Task<StockQuote?> GetByDateAndTickerAsync(DateOnly date, string ticker);
    Task<List<StockQuote>> GetLatestByTickersAsync(List<string> tickers);
    Task AddRangeAsync(List<StockQuote> quotes);
    Task SaveChangesAsync();
}
