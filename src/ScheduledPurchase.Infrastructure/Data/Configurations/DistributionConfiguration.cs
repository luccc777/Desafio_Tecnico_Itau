using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class DistributionConfiguration : IEntityTypeConfiguration<Distribution>
{
    public void Configure(EntityTypeBuilder<Distribution> builder)
    {
        builder.ToTable("distributions");

        builder.HasKey(d => d.Id);

        builder.Property(d => d.Ticker).HasMaxLength(10).IsRequired();
        builder.Property(d => d.UnitPrice).HasPrecision(18, 2);

        builder.HasOne(d => d.PurchaseOrder)
            .WithMany(o => o.Distributions)
            .HasForeignKey(d => d.PurchaseOrderId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(d => d.ChildCustody)
            .WithMany()
            .HasForeignKey(d => d.ChildCustodyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
