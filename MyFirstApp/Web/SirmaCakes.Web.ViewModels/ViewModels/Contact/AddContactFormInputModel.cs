namespace SirmaCakes.Web.ViewModels.ViewModels.ContactForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class AddContactFormInputModel
    {
        [MinLength(3)]
        [Required(ErrorMessage = "Please enter name with a minimum length of 3 symbols.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Questions
        [Required(ErrorMessage = "Please enter questions  with a minimum length of 10 symbols.")]
        [MinLength(10)]
        [StringLength(500)]
        [Display(Name = "Questions")]
        public string Questions { get; set; }
    }
}
