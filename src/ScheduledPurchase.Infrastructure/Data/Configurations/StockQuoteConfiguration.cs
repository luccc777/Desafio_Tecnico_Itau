using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class StockQuoteConfiguration : IEntityTypeConfiguration<StockQuote>
{
    public void Configure(EntityTypeBuilder<StockQuote> builder)
    {
        builder.ToTable("stock_quotes");

        builder.HasKey(q => q.Id);

        builder.Property(q => q.Ticker).HasMaxLength(10).IsRequired();
        builder.Property(q => q.OpenPrice).HasPrecision(18, 2);
        builder.Property(q => q.ClosePrice).HasPrecision(18, 2);
        builder.Property(q => q.HighPrice).HasPrecision(18, 2);
        builder.Property(q => q.LowPrice).HasPrecision(18, 2);

        builder.HasIndex(q => new { q.TradingDate, q.Ticker }).IsUnique();
    }
}
