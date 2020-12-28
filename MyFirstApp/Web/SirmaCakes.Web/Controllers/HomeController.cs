namespace SirmaCakes.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using SirmaCakes.Data.Common.Repositories;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Services.Data;
    using SirmaCakes.Web.ViewModels;
    using SirmaCakes.Web.ViewModels.ViewModels.Home;

    // 1. ApplicationDbContext
    // 2. Repositories
    // 3. Service
    public class HomeController : BaseController
    {
        private readonly IGetCountsService countsService;
        private readonly ICakesService cakesService;

        // 1.Without AutoMapper
        // 2.Can use AutoMapper
        public HomeController(
            IGetCountsService countsService,
            ICakesService cakesService)
        {
            this.countsService = countsService;
            this.cakesService = cakesService;
        }

        public IActionResult Index()
        {
            var counts = this.countsService.GetCounts();

            // With mapper -> var viewModel = this.mapper.Map<IndexViewModel>(countsDto);
            var viewModel = new IndexViewModel
            {
                Year = counts.Year,
                CategoriesCount = counts.CategoriesCount,
                ImagesCount = counts.ImagesCount,
                UsersCount = counts.UsersCount,
                CakesCount = counts.CakesCount,
                RandomCake = this.cakesService.GetRandom<IndexPageRandomCakeViewModel>(3),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
