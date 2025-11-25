using AutocountCRM_ProjectOne.Data;
using AutocountCRM_ProjectOne.Models;
using Microsoft.EntityFrameworkCore;

namespace AutocountCRM_ProjectOne.Repositories;

public class QuotationRepository
{
    private readonly CRMContext _context;
    
    public QuotationRepository(CRMContext context)
    {
        _context = context;
    }

    public async Task<List<QT>> GetAllAsync()
    {
        return await _context.QT
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<QT?> GetByIdAsync(long DocKey)
    {
        return await _context.QT.FindAsync(DocKey);
    }
}