using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
{
    public void Configure(EntityTypeBuilder<BasketItem> builder)
    {
        builder.ToTable("basket_items");

        builder.HasKey(i => i.Id);

        builder.Property(i => i.Ticker).HasMaxLength(10).IsRequired();
        builder.Property(i => i.Percentage).HasPrecision(5, 2);

        builder.HasOne(i => i.Basket)
            .WithMany(b => b.Items)
            .HasForeignKey(i => i.BasketId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
