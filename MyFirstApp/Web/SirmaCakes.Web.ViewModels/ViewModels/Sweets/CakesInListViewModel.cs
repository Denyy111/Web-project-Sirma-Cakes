namespace SirmaCakes.Web.ViewModels.ViewModels.Sweets
{
    using System.Linq;

    using AutoMapper;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Services.Mapping;

    public class CakesInListViewModel : IMapFrom<Cake>, IHaveCustomMappings
    {
        // id for infortamion for cake
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string CakeName { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Cake, CakesInListViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(x =>
                    x.Images.FirstOrDefault().RemoteimageUrl != null ?
                    x.Images.FirstOrDefault().RemoteimageUrl :
                    "/images/cakes/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}
