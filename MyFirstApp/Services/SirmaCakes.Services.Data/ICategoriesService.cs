using System.Collections.Generic;

namespace SirmaCakes.Services.Data
{
    public interface ICategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();
    }
}
