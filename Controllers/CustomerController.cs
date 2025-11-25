using Microsoft.AspNetCore.Mvc;
using AutocountCRM_ProjectOne.Models;
using AutocountCRM_ProjectOne.Repositories;

namespace AutocountCRM_ProjectOne.Controllers;

public class CustomerController : Controller
{
    private readonly CustomerRepository _repo;

    public CustomerController(CustomerRepository repo)
    {
        _repo = repo;
    }

    private bool IsLoggedIn() =>
        !string.IsNullOrEmpty(HttpContext.Session.GetString("UserID"));


    public async Task<IActionResult> Index()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");

        var CustomerList = await _repo.GetAllAsync();
        return View("Customers", CustomerList);
    }

        public IActionResult AddCustomer()
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");
         return View(new Debtor());
    }


     // GET: /Customer/ViewCustomer?CustomerId=5
    [HttpGet]
    public async Task<IActionResult> ViewCustomer(long CustomerId)
    {
        if (!IsLoggedIn()) return RedirectToAction("LogIn", "Home");

        var customer = await _repo.GetByIdAsync(CustomerId);
        if (customer == null) 
            return NotFound();

        return View(customer);
    }

}