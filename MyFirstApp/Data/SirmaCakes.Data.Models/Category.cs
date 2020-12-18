namespace SirmaCakes.Data.Models
{

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using SirmaCakes.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Cakes = new HashSet<Cake>();
        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Cake> Cakes { get; set; }

        // edna category e za mnogo torti edna torta e v edna kategoriq
        // Edno kym mnogo
    }
}
