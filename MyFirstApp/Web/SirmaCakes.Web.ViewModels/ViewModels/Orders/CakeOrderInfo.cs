namespace SirmaCakes.Web.ViewModels.ViewModels.Orders
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class CakeOrderInfo
    {
        // visualisation how to looks ored in acount
        // Quantity

        public int Id { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }
    }
}
