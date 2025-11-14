using Microsoft.AspNetCore.Mvc;
using AutocountCRM_ProjectOne.Models;
using AutocountCRM_ProjectOne.Repositories;

namespace AutocountCRM_ProjectOne.Controllers;

public class LeadsController : Controller
{
    private readonly LeadsRepository _repo;

    public LeadsController(LeadsRepository repo)
    {
        _repo = repo;
    }

    private bool IsLoggedIn() =>
        !string.IsNullOrEmpty(HttpContext.Session.GetString("UserID"));

    // GET: /Leads/Leads (will look for Leads.cshtml)
    public async Task<IActionResult> Index()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");

        var leadslist = await _repo.GetAllAsync();
        return View("Leads", leadslist);
    }

    public IActionResult AddLead()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");
         return View(new leads_list());
    }

    // POST: save new lead
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddLead(leads_list lead)
    {
        if (!IsLoggedIn()) return Json(new { success = false, redirect = Url.Action("LogIn", "Home") });

        if (!ModelState.IsValid)
            return Json(new { success = false, message = "Invalid input" });

        try
        {
            await _repo.AddAsync(lead);
            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }

    [HttpPost]
    public async Task<IActionResult> DeleteLead(int id)
    {
        if (!IsLoggedIn()) return Json(new { success = false, redirect = Url.Action("LogIn", "Home") });

        try
        {
            var lead = await _repo.GetByIdAsync(id);
            if (lead == null)
                return Json(new { success = false, message = "Lead not found" });

            await _repo.DeleteAsync(lead);
            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }


    // GET: /Leads/EditLeads?leadsId=5
    [HttpGet]
    public async Task<IActionResult> EditLeads(int leadsId)
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");
        
        var leadsEdit = await _repo.GetByIdAsync(leadsId);
        if (leadsEdit == null) return NotFound();
        
        return View(leadsEdit);
    }

    // POST: /Leads/EditLeads
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditLeads(int leadsId, leads_list lead)
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");

        // TEMPORARY DEBUG - Remove after fixing
        Console.WriteLine($"leadsId parameter: {leadsId}");
        Console.WriteLine($"lead.Id: {lead.Id}");

        if (leadsId != lead.Id) 
        {
            ModelState.AddModelError("", $"ID mismatch: leadsId={leadsId}, lead.Id={lead.Id}");
            return View(lead);
        }

        if (!ModelState.IsValid)
        {
            return View(lead);
        }

        try
        {
            await _repo.UpdateAsync(lead);

            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }

}