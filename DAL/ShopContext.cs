using back_homework_12._09._2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_homework_12._09._2022.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders {get;set;}
        public DbSet<Product> Products { get; set; }

    }
}
