using Microsoft.EntityFrameworkCore;
using ScheduledPurchase.Domain.Entities;
using ScheduledPurchase.Domain.Enums;
using ScheduledPurchase.Domain.Interfaces;
using ScheduledPurchase.Infrastructure.Data;

namespace ScheduledPurchase.Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly AppDbContext _context;

    public AccountRepository(AppDbContext context) => _context = context;

    public async Task<Account?> GetByIdAsync(long id) =>
        await _context.Accounts.Include(a => a.Custodies).FirstOrDefaultAsync(a => a.Id == id);

    public async Task<Account?> GetMasterAccountAsync() =>
        await _context.Accounts.Include(a => a.Custodies)
            .FirstOrDefaultAsync(a => a.Type == AccountType.Master);

    public async Task<Account?> GetByClientIdAsync(long clientId) =>
        await _context.Accounts.Include(a => a.Custodies)
            .FirstOrDefaultAsync(a => a.ClientId == clientId);

    public async Task AddAsync(Account account) =>
        await _context.Accounts.AddAsync(account);

    public async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}
