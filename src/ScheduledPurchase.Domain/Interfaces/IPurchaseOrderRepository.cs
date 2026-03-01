using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface IPurchaseOrderRepository
{
    Task AddAsync(PurchaseOrder order);
    Task AddRangeAsync(List<PurchaseOrder> orders);
    Task SaveChangesAsync();
}
