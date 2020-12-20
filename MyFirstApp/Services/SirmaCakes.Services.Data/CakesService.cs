namespace SirmaCakes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using SirmaCakes.Data.Common.Repositories;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Web.ViewModels.ViewModels.Sweets;

    public class CakesService : ICakesService
    {
        private readonly IDeletableEntityRepository<Cake> cakesRepository;

        public CakesService(IDeletableEntityRepository<Cake> cakesRepository)
        {
            this.cakesRepository = cakesRepository;
        }

        // Pravim metoda da e asynhronen i da vsyshta task
        public async Task CreateAsync(CreateCakeInputModel input)
        {
            // CategoriId  e dropdoown -> direktno nidava Id

            // Pravim Cake
            var cake = new Cake
            {
                // Images for now is empry
                // User-admin will be empty
                CakeName = input.CakeName,
                Calories = input.Calories,
                CategoryId = input.CategoryId,
                Price = input.Price,
                ShortDescription = input.ShortDescription,
                LongDescription = input.LongDescription,
            };

            // Dobavqme cake// dobavi mi cake v repositorito
            await this.cakesRepository.AddAsync(cake);
            await this.cakesRepository.SaveChangesAsync();
        }
    }
}
