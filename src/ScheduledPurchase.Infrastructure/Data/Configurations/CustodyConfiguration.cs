using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class CustodyConfiguration : IEntityTypeConfiguration<Custody>
{
    public void Configure(EntityTypeBuilder<Custody> builder)
    {
        builder.ToTable("custodies");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Ticker).HasMaxLength(10).IsRequired();
        builder.Property(c => c.AveragePrice).HasPrecision(18, 2);

        builder.HasIndex(c => new { c.AccountId, c.Ticker }).IsUnique();

        builder.HasOne(c => c.Account)
            .WithMany(a => a.Custodies)
            .HasForeignKey(c => c.AccountId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
