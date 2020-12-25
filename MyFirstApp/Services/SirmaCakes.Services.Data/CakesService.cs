namespace SirmaCakes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SirmaCakes.Data.Common.Repositories;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Services.Mapping;
    using SirmaCakes.Web.ViewModels.ViewModels.Sweets;

    public class CakesService : ICakesService
    {
        private readonly IDeletableEntityRepository<Cake> cakesRepository;

        public CakesService(IDeletableEntityRepository<Cake> cakesRepository)
        {
            this.cakesRepository = cakesRepository;
        }

        // Pravim metoda da e asynhronen i da vsyshta task
        public async Task CreateAsync(CreateCakeInputModel input, string userId)
        {
            // CategoriId  e dropdoown -> direktno ni dava Id

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
                AddbyUserId = userId,
            };

            // Dobavqme cake// dobavi mi cake v repositorito
            await this.cakesRepository.AddAsync(cake);
            await this.cakesRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            // orderBy descending - nai skoro dobavenite da sa na pyrva stranica
            var cakes = this.cakesRepository.AllAsNoTracking()
                  .OrderByDescending(x => x.Id)
                  .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                  .To<T>().ToList();

            return cakes;

            // 1 - 12 items - page 1  (page-1) * itemsPerPage
            // 13 - 24 - page 2
            // 25 - 36 - page 3
        }

        public int GetCount()
        {
            return this.cakesRepository.All().Count();
        }
    }
}
