using Microsoft.EntityFrameworkCore;
using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class CustodyRepository : ICustodyRepository
{
    private readonly AppDbContext _context;

    public CustodyRepository(AppDbContext context) => _context = context;

    public async Task<List<Custody>> GetByAccountIdAsync(long accountId) =>
        await _context.Custodies.Where(c => c.AccountId == accountId).ToListAsync();

    public async Task<Custody?> GetByAccountAndTickerAsync(long accountId, string ticker) =>
        await _context.Custodies.FirstOrDefaultAsync(c => c.AccountId == accountId && c.Ticker == ticker);

    public async Task AddAsync(Custody custody) =>
        await _context.Custodies.AddAsync(custody);

    public void Update(Custody custody) =>
        _context.Custodies.Update(custody);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
