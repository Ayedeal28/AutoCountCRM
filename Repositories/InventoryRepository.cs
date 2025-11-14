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

    public async Task<Inventory?> GetByIdAsync(int ItemID)
    {
        return await _context.Inventory.FindAsync(ItemID);
    }

    public async Task UpdateAsync(Inventory inv)
    {
        _context.Inventory.Update(inv);
        await _context.SaveChangesAsync();
    }

    public async Task AddAsync(Inventory inv)
    {
        _context.Inventory.Add(inv);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Inventory inv)
    {
        _context.Inventory.Remove(inv);
        await _context.SaveChangesAsync();
    }


    
}