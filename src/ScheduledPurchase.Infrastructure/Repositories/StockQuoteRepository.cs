using Microsoft.EntityFrameworkCore;
using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class StockQuoteRepository : IStockQuoteRepository
{
    private readonly AppDbContext _context;

    public StockQuoteRepository(AppDbContext context) => _context = context;

    public async Task<StockQuote?> GetByDateAndTickerAsync(DateOnly date, string ticker) =>
        await _context.StockQuotes.FirstOrDefaultAsync(q => q.TradingDate == date && q.Ticker == ticker);

    public async Task<List<StockQuote>> GetLatestByTickersAsync(List<string> tickers) =>
        await _context.StockQuotes
            .Where(q => tickers.Contains(q.Ticker))
            .GroupBy(q => q.Ticker)
            .Select(g => g.OrderByDescending(q => q.TradingDate).First())
            .ToListAsync();

    public async Task AddRangeAsync(List<StockQuote> quotes) =>
        await _context.StockQuotes.AddRangeAsync(quotes);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
