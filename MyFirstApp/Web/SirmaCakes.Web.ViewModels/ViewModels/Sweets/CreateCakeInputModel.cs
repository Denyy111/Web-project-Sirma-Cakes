namespace SirmaCakes.Web.ViewModels.ViewModels.Sweets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class CreateCakeInputModel
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Cake Name")]
        public string CakeName { get; set; }

        [StringLength(50)]
        [Display(Name = "Short description")]
        public string ShortDescription { get; set; }

        [StringLength(255)]
        [Display(Name = "Long description")]
        public string LongDescription { get; set; }

        [Required]
        [Display(Name = "Price in EUR")]
        public decimal Price { get; set; }

        [Required]
        [Range(20, 3000)]
        [Display(Name = "Calories")]
        public int Calories { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
