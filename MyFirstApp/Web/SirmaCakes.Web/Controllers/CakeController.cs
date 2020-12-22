namespace SirmaCakes.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using SirmaCakes.Services.Data;
    using SirmaCakes.Web.ViewModels.ViewModels.Sweets;

    public class CakeController : Controller
    {
        // Get samata forma
        private readonly ICategoriesService categoriesService;
        private readonly ICakesService cakesService;

        public CakeController(
            ICategoriesService categoriesService,
            ICakesService cakesService)
        {
            this.categoriesService = categoriesService;
            this.cakesService = cakesService;
        }

        public IActionResult Create()
        {
            // nezabravqme da podadem na view-to viewModel-a
            var viewModel = new CreateCakeInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCakeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                // nezabravqme da podadem na view-to
                // Vkarvame v input modela categoriite koito s v seeder-a
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            // Create cake with ICakesService- method Create pravim celiq HHTp taska i awaitvame
            // podavame mu direktno input modela
            await this.cakesService.CreateAsync(input);

            // TODO: Redirect to cake Home Page
            return this.Redirect("/");
        }
    }
}
