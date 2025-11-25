using AutocountCRM_ProjectOne.Data;
using AutocountCRM_ProjectOne.Models;
using Microsoft.EntityFrameworkCore;

namespace AutocountCRM_ProjectOne.Repositories;

public class CustomerRepository
{
    private readonly CRMContext _context;
    
    public CustomerRepository(CRMContext context)
    {
        _context = context;
    }

    public async Task<List<Debtor>> GetAllAsync()
    {
        return await _context.Debtor
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Debtor?> GetByIdAsync(long AutoKey)
    {
        return await _context.Debtor.FindAsync(AutoKey);
    }
}