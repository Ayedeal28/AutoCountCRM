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

    public IActionResult AddInventory()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");
         return View(new Inventory());
    }

    // POST: save new Inventory
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddInventory(Inventory inv)
    {
        if (!IsLoggedIn()) return Json(new { success = false, redirect = Url.Action("LogIn", "Home") });

        if (!ModelState.IsValid)
            return Json(new { success = false, message = "Invalid input" });

        try
        {
            await _repo.AddAsync(inv);
            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }

    [HttpPost]
    public async Task<IActionResult> DeleteInventory(int ItemID)
    {
        if (!IsLoggedIn()) return Json(new { success = false, redirect = Url.Action("LogIn", "Home") });

        try
        {
            var inv = await _repo.GetByIdAsync(ItemID);
            if (inv == null)
                return Json(new { success = false, message = "Inventory not found" });

            await _repo.DeleteAsync(inv);
            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }


    // GET: /Inventory/EditInventory?InventoryId=5
    [HttpGet]
    public async Task<IActionResult> EditInventory(int InventoryId)
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");
        
        var InventoryEdit = await _repo.GetByIdAsync(InventoryId);
        if (InventoryEdit == null) return NotFound();
        
        return View(InventoryEdit);
    }

    // POST: /Inventory/EditInventory
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditInventory(int InventoryId, Inventory inv)
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");

        // TEMPORARY DEBUG - Remove after fixing
        Console.WriteLine($"InventoryId parameter: {InventoryId}");
        Console.WriteLine($"inv.Id: {inv.ItemID}");

        if (InventoryId != inv.ItemID) 
        {
            ModelState.AddModelError("", $"ID mismatch: Inventory Id={InventoryId}, inv.ItemID={inv.ItemID}");
            return View(inv);
        }

        if (!ModelState.IsValid)
        {
            return View(inv);
        }

        try
        {
            await _repo.UpdateAsync(inv);

            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = ex.Message });
        }
    }

}