namespace SirmaCakes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SirmaCakes.Data.Common.Repositories;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Services.Mapping;
    using SirmaCakes.Web.ViewModels.ViewModels.Sweets;

    public class CakesService : ICakesService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
        private readonly IDeletableEntityRepository<Cake> cakesRepository;

        public CakesService(IDeletableEntityRepository<Cake> cakesRepository)
        {
            this.cakesRepository = cakesRepository;
        }

        public async Task CreateAsync(CreateCakeInputModel input, string userId, string imagePath)
        {
            // CategoriId  e dropdoown -> direktno ni dava Id

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
                AddedbyUserId = userId,
            };

            // /wwwroot/images/cakes/{id}.ext
            Directory.CreateDirectory($"{imagePath}/cakes/");
            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');
                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    AddedByUserId = userId,
                    Extension = extension,
                };
                cake.Images.Add(dbImage);

                var physicalPath = $"{imagePath}/cakes/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

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
        }

        public int GetCount()
        {
            return this.cakesRepository.All().Count();
        }

        public T GetById<T>(int id)
        {
            var cake = this.cakesRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();

            return cake;
        }
    }
}
