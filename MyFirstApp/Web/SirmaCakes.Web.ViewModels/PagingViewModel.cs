namespace SirmaCakes.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PagingViewModel
    {
        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1; // we have previous page if x > 1

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.CakesCount / this.ItemsPerPage);

        public int CakesCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
