using Microsoft.EntityFrameworkCore;
using PathChallange.Entities;
using PathChallange.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathChallangeDal
{
    public class PathChallangeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-QVNJVT9\\SQLEXPRESS; database=PathChallange; integrated security=true");
        }
        public DbSet<Users> Users {get; set;}
        public DbSet<Authority> Authorities {get; set;}
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders {get; set;}
        public DbSet<ShippingCompany> ShippingCompanies {get; set;}
       
    }
}
