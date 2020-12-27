namespace SirmaCakes.Web.ViewModels.ViewModels.Sweets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AutoMapper;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Services.Mapping;

    public class SingleCakeViewModel : IMapFrom<Cake>, IHaveCustomMappings
    {
        public string CakeName { get; set; }

        public decimal Price { get; set; }

        public string LongDescription { get; set; }

        public string ShortDescription { get; set; }

        public int Calories { get; set; }

        public string ImageUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Cake, SingleCakeViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(x =>
                    x.Images.FirstOrDefault().RemoteImageUrl != null ?
                    x.Images.FirstOrDefault().RemoteImageUrl :
                    "/images/cakes/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}
