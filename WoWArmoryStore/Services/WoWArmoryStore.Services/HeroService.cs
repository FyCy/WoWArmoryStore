namespace WoWArmoryStore.Services
{
    using System.Linq;
    using WoWArmoryStore.Data;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels;

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
            var u = contex.Users.FirstOrDefault(x => x.Id == userId);
            u.MyHeroes.Add(hero);
            this.contex.Heroes.Add(hero);
            this.contex.SaveChanges();
        }
    }
}
