using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WantedClothingWebsite.Data;
using WantedClothingWebsite.Models;

namespace WantedClothingWebsite.Controllers
{
    public class MenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var menProducts = _context.Products.Where(p => p.Category == "Men").ToList();
            return View(menProducts);
        }
    }
}
