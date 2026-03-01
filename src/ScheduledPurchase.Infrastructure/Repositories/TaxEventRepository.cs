using Microsoft.EntityFrameworkCore;
using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class TaxEventRepository : ITaxEventRepository
{
    private readonly AppDbContext _context;

    public TaxEventRepository(AppDbContext context) => _context = context;

    public async Task AddAsync(TaxEvent taxEvent) =>
        await _context.TaxEvents.AddAsync(taxEvent);

    public async Task AddRangeAsync(List<TaxEvent> taxEvents) =>
        await _context.TaxEvents.AddRangeAsync(taxEvents);

    public async Task<List<TaxEvent>> GetUnpublishedAsync() =>
        await _context.TaxEvents.Where(t => !t.PublishedToKafka).ToListAsync();

    public void Update(TaxEvent taxEvent) =>
        _context.TaxEvents.Update(taxEvent);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
