namespace SirmaCakes.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using SirmaCakes.Data.Common.Models;

    public class ContactForm : BaseDeletableModel<int>
    {
        [StringLength(255)]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Questions
        [StringLength(500)]
        [Display(Name = "Questions")]
        public string Questions { get; set; }
    }
}
