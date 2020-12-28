namespace SirmaCakes.Web.ViewModels.ViewModels.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        /* opisvame dannite,koito iskame vuv view da gi ima.
         ot nqkyde trqbwa tezi poleta a bydat vzeeti i nai-pravilno e prez input modela
         Ako iskame da izpolzwame godina, broj akauti, koito da se pokazwat na glavnata stranica, datata
         Za da gi izpolzwame vyv view-otivame tam i nai otgore otbelqzvame ot koe view vzema informaciqta.
        // sled kato izpolzwame propyrtitata ot viewmodela i sme gi podali vyv view-to vyv view-ot otivame v controlera
        v action i tam podaveme informaciqta ot actiona vav view-to.
        */

        public IEnumerable<IndexPageRandomCakeViewModel> RandomCake { get; set; }

        public int Year { get; set; }

        public int CakesCount { get; set; }

        public int CategoriesCount { get; set; }

        public int UsersCount { get; set; }

        public int ImagesCount { get; set; }
    }
}
