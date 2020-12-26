namespace SirmaCakes.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Services.Data;
    using SirmaCakes.Web.ViewModels.ViewModels.Sweets;

    public class CakeController : Controller
    {
        // Get samata forma
        private readonly ICategoriesService categoriesService;
        private readonly ICakesService cakesService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public CakeController(
            ICategoriesService categoriesService,
            ICakesService cakesService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
        {
            this.categoriesService = categoriesService;
            this.cakesService = cakesService;
            this.userManager = userManager;
            this.environment = environment;
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateCakeInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        // Chete formata
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateCakeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                // nezabravqme da podadem na view-to
                // Vkarvame v input modela categoriite koito s v seeder-a
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            // information from cookie
            // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await this.userManager.GetUserAsync(this.User);

            try
            {
                await this.cakesService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            // Create cake with ICakesService- method Create pravim celiq HHTp taska i awaitvame

            // TODO: Redirect to cake Home Page
            return this.Redirect("/");
        }

        // All Cakes
        // Id = number of page
        // Cake/All/ id=page 1,2,3
        // id = 1 by default
        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 12;
            var viewModel = new CakesListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                CakesCount = this.cakesService.GetCount(),
                Cakes = this.cakesService.GetAll<CakesInListViewModel>(id, ItemsPerPage),  // conkretizirame za koi model
            };
            return this.View(viewModel);
        }
    }
}
