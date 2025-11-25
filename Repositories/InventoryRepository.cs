using AutocountCRM_ProjectOne.Data;
using AutocountCRM_ProjectOne.Models;
using Microsoft.EntityFrameworkCore;

namespace AutocountCRM_ProjectOne.Repositories;

public class InventoryRepository
{
    private readonly CRMContext _context;
    
    public InventoryRepository(CRMContext context)
    {
        _context = context;
    }

    public async Task<List<Inventory>> GetAllAsync()
    {
        return await _context.Inventory
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Inventory?> GetByIdAsync(long AutoKey)
    {
        return await _context.Inventory.FindAsync(AutoKey);
    }
}