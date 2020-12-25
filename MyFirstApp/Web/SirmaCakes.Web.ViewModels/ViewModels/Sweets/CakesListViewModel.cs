namespace SirmaCakes.Web.ViewModels.ViewModels.Sweets
{
    using System;
    using System.Collections.Generic;

    public class CakesListViewModel : PagingViewModel
    {
        // Koi sa tortite za vizualizirane// shte raboti sys vseki validen view model
        public IEnumerable<CakesInListViewModel> Cakes { get; set; }
    }
}
