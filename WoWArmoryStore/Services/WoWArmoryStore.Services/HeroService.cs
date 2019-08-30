namespace WoWArmoryStore.Services
{
    using System.Linq;
    using WoWArmoryStore.Data;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels;
    using WoWArmoryStore.Services.Mapping;
    using Microsoft.AspNetCore.Identity;
    using System.Net.Http;

    public class HeroService : IHeroService
    {
        private readonly ApplicationDbContext contex;

        public HeroService(ApplicationDbContext contex)
        {
            this.contex = contex;
        }

        public void CreateNewHero(CreateHeroInputModel model, string user, string userId)
        {
            var hero = new Hero
            {
                HeroName = model.HeroName,
                HeroFaction = model.HeroFaction,
                HeroRace = model.HeroRace,
                HeroClass = model.HeroClass,
                WoWUserName = user,
                WoWArmoryUserId = userId,
            };
            this.contex.Heroes.Add(hero);
            this.contex.SaveChanges();
        }
    }
}
