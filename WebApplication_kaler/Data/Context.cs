using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_kaler.DAL.Entities;

namespace WebApplication_kaler.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_kaler.DAL.Entities.Dish> Dish { get; set; }
    }
}
