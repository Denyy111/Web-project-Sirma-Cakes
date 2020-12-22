namespace SirmaCakes.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SirmaCakes.Services.Data;
    using SirmaCakes.Web.ViewModels.ViewModels.ContactForm;

    public class ContactController : BaseController
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

       
        public IActionResult Add()
        {
            var viewModel = new AddContactFormInputModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddContactFormInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.contactService.CreateContact(input);
            return this.Redirect("/");
        }
    }
}
