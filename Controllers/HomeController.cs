using back_homework_12._09._2022.DAL;
using back_homework_12._09._2022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace back_homework_12._09._2022.Controllers
{
    public class HomeController : Controller
    {
        ShopContext _context { get; }

        HomeController(ShopContext context) {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        
    }
}
