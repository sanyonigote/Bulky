using Bulky.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Aman", DisplayOrder = 9 },
                 new Category { CategoryId = 2, Name = "Faizal", DisplayOrder = 7 },
                  new Category { CategoryId = 3, Name = "GT", DisplayOrder = 6 }
                );
            modelBuilder.Entity<Product>().HasData(
               new Product { ProductId = 1, Title = "Animal Stories", Author = "Maria Hoey and Peter Hoey", ISBN = "978-1-60309-502-0", Description = "A delightfully strange collection of linked stories pondering just how little people truly know about animals.", ListPrice = 90, Price = 87, Price50 = 67, Price100 = 67, ImageUrl = "",CategoryId=1 },
               new Product { ProductId = 2, Title = "Chester 5000", Author = " Jess Fink", ISBN = "978-1-60309-535-8", Description = "Sexy and charming This is pornography with a heart", ListPrice = 56, Price = 52, Price50 = 45, Price100 = 43, ImageUrl = "",CategoryId=2 },
               new Product
               {
                   ProductId = 3,
                   Title = "F.A.R.M. System",
                   Author = "Rich Koslowski",
                   ISBN = "978-1-60309-515-0",
                   Description = " If superheroes were real, they’d be a lot like pro athletes. But when supers start mysteriously dropping dead, all the agents and managers in the world may not be able to save them...",
                   ListPrice = 90,
                   Price = 89,
                   Price50 = 78,
                   Price100 = 67,
                   ImageUrl = "",CategoryId=2

               },
               new Product
               {
                   ProductId = 4,
                   Title = "Hell: Master Edition ",
                   ISBN = "UPC 827714016215",
                   Author = "Eddie Campbell",
                   Description = "The first modern serial killer strikes his first victims, and reluctant Inspector Abberline is assigned the case of a lifetime.",
                   ListPrice = 90,
                   Price = 56,
                   Price50 = 45,
                   Price100 = 43,
                   ImageUrl = "",CategoryId=3

               },
               new Product
               {
                   ProductId = 5,
                   Title = "Incredible Change-Bots One",
                   ISBN = "978-1-891830-91-4",
                   Author = "Jeffrey Brown",
                   Description = "This pocket-sized volume is to The Transformers what Avenue Q is to Sesame Street -- a mocking, fawning, idiotic, adoring paean to a pop culture phenomenon inseparable from the artist’s person. Although allegory without substance, all action and no moral, it’s delightful fluff",
                   ListPrice = 89,
                   Price = 78,
                   Price50 = 76,
                   Price100 = 56,
                   ImageUrl = "",
                   CategoryId=3

               }
               );

        }
    }



}


    
       