namespace SirmaCakes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using SirmaCakes.Data.Models;
    using SirmaCakes.Web.ViewModels.ViewModels.CartItems;
    using SirmaCakes.Web.ViewModels.ViewModels.Sweets;

    public interface ICakesService
    {
        // tuk opisvame metodite, kato izpolzwame dannite ot input modela i ot nego pravim cake
        Task CreateAsync(CreateCakeInputModel input, string userId, string imagePath);

        // for templeate // CakesInListViewModel
        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        int GetCount();

        T GetById<T>(int id); // dannite za cake v cassa koit go iskame 

        IEnumerable<T> GetRandom<T>(int count);

        //Task<int> AddToCartAsync(Cake cake, int qty = 1);

        //Task ClearCartAsync();

        //Task<IEnumerable<CartItemsViewModel>> GetShoppingCartItemsAsync();

        //Task<int> RemoveFromCartAsync(Cake cake);

        //Task<(int ItemCount, decimal TotalAmmount)> GetCartCountAndTotalAmmountAsync();
    }
}
