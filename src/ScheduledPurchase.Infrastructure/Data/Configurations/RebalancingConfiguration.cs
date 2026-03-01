using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class RebalancingConfiguration : IEntityTypeConfiguration<Rebalancing>
{
    public void Configure(EntityTypeBuilder<Rebalancing> builder)
    {
        builder.ToTable("rebalancings");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.SoldTicker).HasMaxLength(10).IsRequired();
        builder.Property(r => r.BoughtTicker).HasMaxLength(10).IsRequired();
        builder.Property(r => r.Type).HasConversion<string>().HasMaxLength(20);
        builder.Property(r => r.SaleAmount).HasPrecision(18, 2);
        builder.Property(r => r.PurchaseAmount).HasPrecision(18, 2);

        builder.HasOne(r => r.Client)
            .WithMany()
            .HasForeignKey(r => r.ClientId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
