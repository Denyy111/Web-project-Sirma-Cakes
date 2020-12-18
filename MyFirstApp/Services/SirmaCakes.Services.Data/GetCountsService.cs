namespace SirmaCakes.Services.Data
{
    using System;
    using System.Linq;

    using SirmaCakes.Data.Common.Repositories;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Services.Data.Dtos;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<Cake> cakeRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly IRepository<Image> imageRepository;

        public GetCountsService(
          IDeletableEntityRepository<Category> categoryRepository,
          IDeletableEntityRepository<Cake> cakeRepository,
          IDeletableEntityRepository<ApplicationUser> userRepository,
          IRepository<Image> imageRepository)
        {
            this.categoryRepository = categoryRepository;
            this.userRepository = userRepository;
            this.cakeRepository = cakeRepository;
            this.imageRepository = imageRepository;
        }

        public CountsDto GetCounts()
        {
            var data = new CountsDto
            {
                // from DB
                Year = DateTime.UtcNow.Year,
                CategoriesCount = this.categoryRepository.All().Count(),
                CakesCount = this.cakeRepository.All().Count(),
                UsersCount = this.userRepository.All().Count(),
                ImagesCount = this.imageRepository.All().Count(),

            };

            return data;
        }
    }
}
