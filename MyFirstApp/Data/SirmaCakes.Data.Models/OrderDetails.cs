namespace SirmaCakes.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using SirmaCakes.Data.Common.Models;

    public class OrderDetails : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(255)]
        public string CakeName { get; set; }

        // Quantity
        public int Qty { get; set; }

        public decimal Price { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
