using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DutchTreat.Data
{
    public class DutchContext : DbContext
    {
       /* private readonly IConfiguration _config;
        public DutchContext(IConfiguration config)
        {

            _config = config;
        }*/

        /**/public DutchContext(DbContextOptions<DutchContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           base.OnConfiguring(optionsBuilder);

           optionsBuilder.UseSqlServer(_config["ConnectionStrings:DutchContextDb"]);
       }*/
        /**/protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasData(new Order()
                {
                    Id = 1,
                    OrderDate = DateTime.UtcNow,
                    OrderNumber = "12345"
                });
        }
    }
}
