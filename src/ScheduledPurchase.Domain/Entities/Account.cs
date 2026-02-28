using ScheduledPurchase.Domain.Enums;

namespace ScheduledPurchase.Domain.Entities;

public class Account
{
    public long Id { get; set; }
    public long? ClientId { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
    public AccountType Type { get; set; }
    public DateTime CreatedAt { get; set; }

    public Client? Client { get; set; }
    public List<Custody> Custodies { get; set; } = new();
}
