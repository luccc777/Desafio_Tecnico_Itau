using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class TaxEventConfiguration : IEntityTypeConfiguration<TaxEvent>
{
    public void Configure(EntityTypeBuilder<TaxEvent> builder)
    {
        builder.ToTable("tax_events");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Ticker).HasMaxLength(10);
        builder.Property(t => t.Type).HasConversion<string>().HasMaxLength(20);
        builder.Property(t => t.BaseAmount).HasPrecision(18, 2);
        builder.Property(t => t.TaxAmount).HasPrecision(18, 2);

        builder.HasOne(t => t.Client)
            .WithMany()
            .HasForeignKey(t => t.ClientId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
