namespace SirmaCakes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using SirmaCakes.Data.Common.Repositories;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Web.ViewModels.ViewModels.ContactForm;

    public class ContactService : IContactService
    {
        private readonly IDeletableEntityRepository<ContactForm> contactRepository;

        public ContactService(IDeletableEntityRepository<ContactForm> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public async Task CreateContact(AddContactFormInputModel input)
        {
            // Pravim formata
            var contactForm = new ContactForm
            {
                Name = input.Name,
                Email = input.Email,
                Questions = input.Questions,
            };

            // Dobavqme cake// dobavi mi cake v repositorito
            await this.contactRepository.AddAsync(contactForm);
            await this.contactRepository.SaveChangesAsync();
        }
    }
}
