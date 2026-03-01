using Microsoft.EntityFrameworkCore;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<Custody> Custodies => Set<Custody>();
    public DbSet<RecommendationBasket> RecommendationBaskets => Set<RecommendationBasket>();
    public DbSet<BasketItem> BasketItems => Set<BasketItem>();
    public DbSet<PurchaseOrder> PurchaseOrders => Set<PurchaseOrder>();
    public DbSet<Distribution> Distributions => Set<Distribution>();
    public DbSet<TaxEvent> TaxEvents => Set<TaxEvent>();
    public DbSet<Rebalancing> Rebalancings => Set<Rebalancing>();
    public DbSet<StockQuote> StockQuotes => Set<StockQuote>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
