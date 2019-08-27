namespace WoWArmoryStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using WoWArmoryStore.Data;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels.ViewModels;
    using WoWArmoryStore.Services.Mapping;

    public class UserHeroesService : IUserHeroesService
    {
        private readonly ApplicationDbContext db;

        public UserHeroesService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public ICollection<UserHeroViewModel> UsersHeroes(string userName)
        {
            ICollection<UserHeroViewModel> userHeroes = this.db.Heroes
                .Where(hero => hero.WoWUserName == userName).To<UserHeroViewModel>().ToList();

            return userHeroes;
        }
    }
}
