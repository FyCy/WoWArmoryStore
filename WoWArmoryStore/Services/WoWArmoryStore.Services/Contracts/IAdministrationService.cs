namespace WoWArmoryStore.Services.Contracts
{
    using System.Collections.Generic;

    using WoWArmoryStore.Web.ViewModels.ViewModels;

    public interface IAdministrationService
    {
        ICollection<UserViewModel> UserViewModels(string userId);

        ICollection<ItemViewModel> ItemViewModels();

        void DeleteUser(string id);

        void DeleteItem(int id);

    }
}
