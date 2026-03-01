using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class RecommendationBasketConfiguration : IEntityTypeConfiguration<RecommendationBasket>
{
    public void Configure(EntityTypeBuilder<RecommendationBasket> builder)
    {
        builder.ToTable("recommendation_baskets");

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name).HasMaxLength(100).IsRequired();
    }
}
