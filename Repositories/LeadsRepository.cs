using AutocountCRM_ProjectOne.Data;
using AutocountCRM_ProjectOne.Models;
using Microsoft.EntityFrameworkCore;

namespace AutocountCRM_ProjectOne.Repositories;

public class LeadsRepository
{
    private readonly CRMContext _context;
    
    public LeadsRepository(CRMContext context)
    {
        _context = context;
    }

    public async Task<List<leads_list>> GetAllAsync()
    {
        return await _context.leads_list
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<leads_list?> GetByIdAsync(int leadsId)
    {
        return await _context.leads_list.FindAsync(leadsId);
    }

    public async Task UpdateAsync(leads_list lead)
    {
        _context.leads_list.Update(lead);
        await _context.SaveChangesAsync();
    }

    public async Task AddAsync(leads_list lead)
    {
        _context.leads_list.Add(lead);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(leads_list lead)
    {
        _context.leads_list.Remove(lead);
        await _context.SaveChangesAsync();
    }


    
}