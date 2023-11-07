using Inheritance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class DatabaseDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Fruits> Fruits { get; set; }
        public virtual DbSet<Waters> Waters { get; set; }
        public virtual DbSet<StillWater> StillWater { get; set; }
        public virtual DbSet<CarbonatedWater> CarbonatedWater { get; set; }
        public DatabaseDbContext()
        {
            //Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7DUGPCC;Initial Catalog=Inheritance;Integrated Security=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPH  (Table per hierarchy - ierarxiya bo'yicha jadval)
            //modelBuilder.Entity<Product>()
            //    .UseTphMappingStrategy();

            // TPT
            //modelBuilder.Entity<Product>()
            //    .UseTptMappingStrategy();

            //TPC
            modelBuilder.Entity<Product>()
                .UseTpcMappingStrategy();
        }
    }
}
