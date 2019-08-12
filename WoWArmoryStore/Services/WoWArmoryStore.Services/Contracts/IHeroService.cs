namespace WoWArmoryStore.Services.Contracts
{
    using WoWArmoryStore.Services.Models;
    using WoWArmoryStore.Web.ViewModels;

    public interface IHeroService
    {
        void CreateNewHero(CreateHeroInputModel model, string currUser);
    }
}
