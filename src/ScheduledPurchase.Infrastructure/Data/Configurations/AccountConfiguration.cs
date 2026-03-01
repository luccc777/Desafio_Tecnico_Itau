using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Infrastructure.Data.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("accounts");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.AccountNumber).HasMaxLength(20).IsRequired();
        builder.Property(a => a.Type).HasConversion<string>().HasMaxLength(10);

        builder.HasIndex(a => a.AccountNumber).IsUnique();

        builder.HasOne(a => a.Client)
            .WithOne(c => c.Account)
            .HasForeignKey<Account>(a => a.ClientId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
