//using System.Diagnostics;
//using Microsoft.AspNetCore.Mvc;
//using Employee_Management_System.Models;
//using Employee_Management_System.Data;

namespace Employee_Management_System.Controllers;
using Employee_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Employee_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;

    //}

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }
    //Get:Home/Index
    public async Task<IActionResult> Index()
    {
        var employees = await _context.Employees.ToListAsync();
        return View(employees);
    }
    //public IActionResult Index()
    //{
    //    return View();
    //}

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
}
