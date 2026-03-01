using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
{
    public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
    {
        builder.ToTable("purchase_orders");

        builder.HasKey(o => o.Id);

        builder.Property(o => o.Ticker).HasMaxLength(10).IsRequired();
        builder.Property(o => o.UnitPrice).HasPrecision(18, 2);
        builder.Property(o => o.MarketType).HasConversion<string>().HasMaxLength(15);

        builder.HasOne(o => o.MasterAccount)
            .WithMany()
            .HasForeignKey(o => o.MasterAccountId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
