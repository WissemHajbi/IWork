using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IWork.Models;
using Microsoft.EntityFrameworkCore;

namespace IWork.Controllers;

public class HomeController : Controller
{
    private readonly IWorkDbContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,IWorkDbContext wc)
    {
        _context = wc;
        _logger = logger;
    }
    
    public async Task<IActionResult> Index()
    {
        var Employers = await _context.Employers.ToListAsync();
        return View(Employers);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
