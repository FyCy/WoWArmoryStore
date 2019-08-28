namespace WoWArmoryStore.Services.Contracts
{
    using System.Collections.Generic;
    using WoWArmoryStore.Web.ViewModels.ViewModels;

    public interface IUserHeroesService
    {
        ICollection<UserHeroViewModel> UsersHeroes(string userName);

        void DeleteHero(string userName, string heroNam);
    }
}
