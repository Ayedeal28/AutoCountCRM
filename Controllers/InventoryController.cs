using Microsoft.AspNetCore.Mvc;
using AutocountCRM_ProjectOne.Models;
using AutocountCRM_ProjectOne.Repositories;

namespace AutocountCRM_ProjectOne.Controllers;

public class InventoryController : Controller
{
    private readonly InventoryRepository _repo;

    public InventoryController(InventoryRepository repo)
    {
        _repo = repo;
    }

    private bool IsLoggedIn() =>
        !string.IsNullOrEmpty(HttpContext.Session.GetString("UserID"));

    // GET: /Inventory/ (will look for Inventory.cshtml)
    public async Task<IActionResult> Index()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");

        var InventoryList = await _repo.GetAllAsync();
        return View("Inventory", InventoryList);
    }

    // GET: /Inventory/ViewInventory?InventoryId=5
    [HttpGet]
    public async Task<IActionResult> ViewInventory(long InventoryId)
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");

        var inventory = await _repo.GetByIdAsync(InventoryId);
        if (inventory == null) 
            return NotFound();

        return View(inventory);
    }


}