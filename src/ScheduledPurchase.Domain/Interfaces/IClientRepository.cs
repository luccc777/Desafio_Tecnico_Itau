using ScheduledPurchase.Domain.Entities;

namespace ScheduledPurchase.Domain.Interfaces;

public interface IClientRepository
{
    Task<Client?> GetByIdAsync(long id);
    Task<Client?> GetByCpfAsync(string cpf);
    Task<bool> ExistsByCpfAsync(string cpf);
    Task<bool> ExistsByEmailAsync(string email);
    Task<List<Client>> GetAllActiveAsync();
    Task AddAsync(Client client);
    void Update(Client client);
    Task SaveChangesAsync();
}
