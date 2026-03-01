using Microsoft.EntityFrameworkCore;
using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context) => _context = context;

    public async Task<Client?> GetByIdAsync(long id) =>
        await _context.Clients.Include(c => c.Account).FirstOrDefaultAsync(c => c.Id == id);

    public async Task<Client?> GetByCpfAsync(string cpf) =>
        await _context.Clients.FirstOrDefaultAsync(c => c.Cpf == cpf);

    public async Task<bool> ExistsByCpfAsync(string cpf) =>
        await _context.Clients.AnyAsync(c => c.Cpf == cpf);

    public async Task<bool> ExistsByEmailAsync(string email) =>
        await _context.Clients.AnyAsync(c => c.Email == email);

    public async Task<List<Client>> GetAllActiveAsync() =>
        await _context.Clients.Where(c => c.Active).Include(c => c.Account).ToListAsync();

    public async Task AddAsync(Client client) =>
        await _context.Clients.AddAsync(client);

    public void Update(Client client) =>
        _context.Clients.Update(client);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
