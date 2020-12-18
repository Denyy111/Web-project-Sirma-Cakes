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

        public CakeController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Create()
        {
            // nezabravqme da podadem na view-to viewModel-a
            var viewModel = new CreateCakeInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateCakeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                // nezabravqme da podadem na view-to
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            // Create cake using service method
            // Todo: redirect to cake info page
            return this.Redirect("/");
        }
    }
}
