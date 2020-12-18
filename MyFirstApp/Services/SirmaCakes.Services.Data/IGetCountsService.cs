namespace SirmaCakes.Services.Data
{
    using SirmaCakes.Services.Data.Dtos;

    public interface IGetCountsService
    {
        // 1. Use the View Model
        // 2. Create DTO -> w nego controller view model
        // 3. Tupels -> Opisvame kakvo vrushta
        CountsDto GetCounts();
    }
}
