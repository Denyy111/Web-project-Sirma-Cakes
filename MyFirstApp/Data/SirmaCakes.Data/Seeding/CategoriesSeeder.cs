namespace SirmaCakes.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SirmaCakes.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            // Even if the DB is dropped, these categories will remain
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Pastry" });
            await dbContext.Categories.AddAsync(new Category { Name = "Cake" });

            await dbContext.SaveChangesAsync();
        }
    }
}
