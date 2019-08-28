namespace WoWArmoryStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using WoWArmoryStore.Data;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Models;
    using WoWArmoryStore.Web.ViewModels;

    public class HeroService : IHeroService
    {
        private readonly ApplicationDbContext contex;

        public HeroService(ApplicationDbContext contex)
        {
            this.contex = contex;
        }

        public void CreateNewHero(CreateHeroInputModel model, string user)
        {
            var hero = new Hero
            {
                HeroName = model.HeroName,
                HeroFaction = model.HeroFaction,
                HeroRace = model.HeroRace,
                HeroClass = model.HeroClass,
                WoWUserName = user,
            };
            this.contex.Heroes.Add(hero);
            this.contex.SaveChanges();
        }
    }
}
