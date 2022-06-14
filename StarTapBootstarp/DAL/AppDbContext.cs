using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StarTapBootstarp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarTapBootstarp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
       public DbSet<Setting> Settings { get; set; }
        public DbSet<StartImage> StartImages { get; set; }

    }
       
    
}
