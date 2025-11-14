using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AutocountCRM_ProjectOne.Models;
using AutocountCRM_ProjectOne.Data;
using Microsoft.EntityFrameworkCore;

namespace AutocountCRM_ProjectOne.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CRMContext _context;

    public HomeController(ILogger<HomeController> logger, CRMContext context)
    {
        _logger = logger;
        _context = context;
    }

    // ===== LOGIN =====
    [HttpGet]
    public IActionResult LogIn()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> LogIn(string email, string password)
    {
        var user = await _context.UsersLogin.FirstOrDefaultAsync(u => u.Email == email);


        if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            HttpContext.Session.SetString("UserID", user.Id.ToString());
            HttpContext.Session.SetString("UserRole", user.Role);
            return RedirectToAction("Index");
        }
        
        ViewBag.Error = "Invalid login";
        return View();
    }

    // ===== LOGOUT =====
    public IActionResult LogOut()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("LogIn");
    }

    // ===== ORIGINAL METHODS (protected by login) =====
    public async Task<IActionResult> Index()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn");
        var QuotationCount = await _context.quotation_list.CountAsync();
        var leadCount = await _context.leads_list.CountAsync();
        ViewBag.LeadCount = leadCount;
        ViewBag.quotationCount = QuotationCount;

        return View();
    }


    // public async Task<IActionResult> Inventory()
    // {
    //     if (!IsLoggedIn()) return RedirectToAction("LogIn");
    //     var inventory = await _context.inventory.ToListAsync();
    //     return View(inventory);
    // }


    // public async Task<IActionResult> EditInventory(int id)
    // {
    //     if (!IsLoggedIn()) return RedirectToAction("LogIn");

    //     var item = await _context.inventory.FindAsync(id);

    //     if (item == null) return NotFound();

    //     return View(item);
    // }

    public IActionResult Customers()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn");
        return View();
    }

    public IActionResult Quotation()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn");
        var quotations = _context.quotation_list.ToList();
        return View(quotations);
    }

    public async Task<IActionResult> manageuser() 
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn");
        var users = await _context.Users.ToListAsync();
        return View(users); 
    }

    // public async Task<IActionResult> Leads()
    // {
    //     if (!IsLoggedIn()) return RedirectToAction("LogIn");
    //     var leadslist = await _context.leads_list.ToListAsync();
    //     return View(leadslist);
    // }

    // public async Task<IActionResult> EditLeads(int leadsId)
    // {
    //     if (!IsLoggedIn()) return RedirectToAction("LogIn");
    //     var leadsEdit = await _context.leads_list.FindAsync(leadsId);

    //     if (leadsEdit == null) return NotFound();

    //     return View(leadsEdit);
    // }


    // =================

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    // ===== HELPER =====
    private bool IsLoggedIn()
    {
        return !string.IsNullOrEmpty(HttpContext.Session.GetString("UserID"));
    }
}
