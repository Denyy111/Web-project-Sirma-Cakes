namespace SirmaCakes.Web.ViewModels.ViewModels.Sweets
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SirmaCakes.Data.Models;

    public class CakeListViewModel
    {
        public IEnumerable<Cake> Cakes { get; set; }

        public string Currentcategory { get; set; }
    }
}
