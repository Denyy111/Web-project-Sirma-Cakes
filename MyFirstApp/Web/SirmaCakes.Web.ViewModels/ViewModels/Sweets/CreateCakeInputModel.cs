namespace SirmaCakes.Web.ViewModels.ViewModels.Sweets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Http;

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
        [Range(1, 300, ErrorMessage = "Price must be between €1 and €300")]
        [Display(Name = "Price in €")]
        public decimal Price { get; set; }

        [Required]
        [Range(20, 3000, ErrorMessage = "Calories must be between 20 and 3000")]
        [Display(Name = "Calories")]
        public int Calories { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
