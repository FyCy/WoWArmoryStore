namespace WoWArmoryStore.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using WoWArmoryStore.Data;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Mapping;
    using WoWArmoryStore.Web.ViewModels.ViewModels;

    public class UserHeroesService : IUserHeroesService
    {
        private readonly ApplicationDbContext db;

        public UserHeroesService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public void DeleteHero(string userName, int id)
        {
            var heroToDelete = this.db.Heroes.FirstOrDefault(x => x.WoWUserName == userName && x.Id == id);
            this.db.Heroes.Remove(heroToDelete);
            this.db.SaveChanges();
        }

        public ICollection<UserHeroViewModel> UsersHeroes(string userName)
        {
            ICollection<UserHeroViewModel> userHeroes = this.db.Heroes
                .Where(hero => hero.WoWUserName == userName).To<UserHeroViewModel>().ToList();

            return userHeroes;
        }
    }
}

