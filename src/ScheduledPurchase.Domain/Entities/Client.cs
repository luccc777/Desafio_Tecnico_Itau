namespace ScheduledPurchase.Domain.Entities;

public class Client
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public decimal MonthlyAmount { get; set; }
    public bool Active { get; set; } = true;
    public DateTime JoinDate { get; set; }
    public DateTime? ExitDate { get; set; }

    public Account? Account { get; set; }
}
