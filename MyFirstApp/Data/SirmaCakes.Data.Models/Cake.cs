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

        public string CakeName { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        public int Calories { get; set; }

        public string AddedbyUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
