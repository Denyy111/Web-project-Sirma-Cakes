namespace SirmaCakes.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using SirmaCakes.Data.Common.Models;

    public class ShopingCartItem : BaseDeletableModel<int>
    {
        public int Qty { get; set; }

        public int CakeId { get; set; }

        public Cake Cake { get; set; }

        [Required]
        [StringLength(255)]
        public string ShoppingCartId { get; set; }
    }
}
