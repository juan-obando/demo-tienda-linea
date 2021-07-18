using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tienda.Models;

namespace tienda.Data
{
    public class MvcWebAppDbContext : DbContext
    {
        public MvcWebAppDbContext(DbContextOptions<MvcWebAppDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Producto> Products { get; set;}
    }
}