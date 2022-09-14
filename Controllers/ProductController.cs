using back_homework_12._09._2022.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_homework_12._09._2022.Controllers
{
    public class ProductController : Controller
    {
        ShopContext _context { get; }

        public ProductController(ShopContext context) {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products.OrderByDescending(p=>p.Price));
        }
    }
}
