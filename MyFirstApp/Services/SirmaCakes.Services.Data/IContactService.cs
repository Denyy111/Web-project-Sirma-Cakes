namespace SirmaCakes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using SirmaCakes.Web.ViewModels.ViewModels.ContactForm;

    public interface IContactService
    {
        // tuk opisvame metodite, kato izpolzwame dannite ot input modela i ot nego pravim contactForm
        Task CreateContact(AddContactFormInputModel input);
    }
}
