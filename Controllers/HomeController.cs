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
    
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> JobHunting()
    {
        var Employers = await _context.Employers.ToListAsync();
        return View(Employers);
    }
    
    public async Task<IActionResult> Interv()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> JobOffer(int id)
    {
        var Employer = await _context.Employers.FirstOrDefaultAsync(x => x.Id == id);
        return View(Employer);
    }

    public IActionResult JobApplyForm()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> JobApplyForm([Bind("Name,Prename,Email,Experience,Description,StartDate")] ApplyModel am)
    {
        if (ModelState.IsValid)
        {
            am.StartDate = DateTime.Today;

            await _context.Applys.AddAsync(am);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(JobHunting));
        }
        
        return View(am);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
