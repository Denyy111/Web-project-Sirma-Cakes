namespace SirmaCakes.Web.ViewModels.ViewModels.CartItems
{
    using System.ComponentModel.DataAnnotations;

    using SirmaCakes.Data.Models;

    public class CartItemsViewModel
    {
        public int Qty { get; set; }

        public int CakeId { get; set; }

        public Cake Cake { get; set; }

        [Required]
        [StringLength(255)]
        public string ShoppingCartId { get; set; }
    }
}
