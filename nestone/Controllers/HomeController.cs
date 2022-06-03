using Microsoft.AspNetCore.Mvc;
using nestone.DAL;
using nestone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nestone.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
       
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync()
            return View(sliders)
        }
      

    }
}
