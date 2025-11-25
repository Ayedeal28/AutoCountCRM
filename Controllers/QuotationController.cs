using Microsoft.AspNetCore.Mvc;
using AutocountCRM_ProjectOne.Models;
using AutocountCRM_ProjectOne.Repositories;

namespace AutocountCRM_ProjectOne.Controllers;

public class QuotationController : Controller
{
    private readonly QuotationRepository _repo;

    public QuotationController(QuotationRepository repo)
    {
        _repo = repo;
    }

    private bool IsLoggedIn() =>
        !string.IsNullOrEmpty(HttpContext.Session.GetString("UserID"));

    // GET: /Quotation/
    public async Task<IActionResult> Index()
    {
        if (!IsLoggedIn()) 
            return RedirectToAction("LogIn", "Home");

        var quotationList = await _repo.GetAllAsync();
        return View("Quotation", quotationList);
    }

    // GET: /Quotation/ViewQuotation?QuotationId=5
    [HttpGet]
    public async Task<IActionResult> ViewQuotation(long QuotationId)
    {
        if (!IsLoggedIn()) 
            return RedirectToAction("LogIn", "Home");

        var quotation = await _repo.GetByIdAsync(QuotationId);
        if (quotation == null) 
            return NotFound();

        return View(quotation); 
    }
}
