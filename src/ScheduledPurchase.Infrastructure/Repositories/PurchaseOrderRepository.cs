using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class PurchaseOrderRepository : IPurchaseOrderRepository
{
    private readonly AppDbContext _context;

    public PurchaseOrderRepository(AppDbContext context) => _context = context;

    public async Task AddAsync(PurchaseOrder order) =>
        await _context.PurchaseOrders.AddAsync(order);

    public async Task AddRangeAsync(List<PurchaseOrder> orders) =>
        await _context.PurchaseOrders.AddRangeAsync(orders);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
