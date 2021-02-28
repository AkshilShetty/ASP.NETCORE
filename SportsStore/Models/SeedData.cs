using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app) {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();

            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                     new Product
                     {
                         Name = "Lifejacket",
                         Description = "Protectible and fashionable",
                         Category = "Watersports",
                         Price = 48.95m
                     },
                     new Product
                     {
                         Name = "Soccer ball",
                         Description = "Fifa-approved size and weight",
                         Category = "soccer",
                         Price = 19.50m
                     },
                     new Product
                     {
                         Name = "Thinking cap",
                         Description = "Improve brain efficiency by 75%",
                         Category = "Chess",
                         Price = 16m
                     },
                     new Product
                     {
                         Name = "Corner Flags",
                         Description = "Give your playing field a professional touch",
                         Category = "soccer",
                         Price = 34.95m
                     },
                     new Product
                     {
                         Name = "Unsteady Chair",
                         Description = "Secretly give your opponent a disadvantage",
                         Category = "chess",
                         Price = 29.95m
                     },
                     new Product
                     {
                         Name = "Human Chess Board",
                         Description = "A fun game for the family",
                         Category = "Chess",
                         Price = 75
                     },
                     new Product
                     {
                         Name = "Stadium",
                         Description = "Flat-packed 35,000-seat stadium",
                         Category = "Chess",
                         Price = 79500
                     },
                     new Product
                     {
                         Name = "bling bling king",
                         Description = "gold plated, diamond",
                         Category = "Chess",
                         Price = 1200
                     });
                    
                context.SaveChanges();
            }
        }

        
        
    }
}
