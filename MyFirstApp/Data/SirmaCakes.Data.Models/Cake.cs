namespace SirmaCakes.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using SirmaCakes.Data.Common.Models;

    // za Vsqka torta bazovi
    public class Cake : BaseDeletableModel<int>
    {
        public Cake()
        {

            this.Images = new HashSet<Image>();
        }

        [Required]
        [StringLength(255)]
        public string CakeName { get; set; }

        [Required]
        [StringLength(50)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string LongDescription { get; set; }

        [Required]
        [StringLength(255)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        public int Calories { get; set; }

        public string AddedbyUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Image> Images { get; set; }


    }
}