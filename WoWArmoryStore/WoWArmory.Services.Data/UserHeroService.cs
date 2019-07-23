using System.Collections.Generic;
using System.Linq;
using WoWArmory.Data;
using WoWArmory.Models.Common;
using WoWArmory.Services.Data.Contracts;
namespace WoWArmory.Services.Data
{
    public class UserHeroService : IUserHeroesService
    {
        protected WoWArmoryDbContext Db { get; }
        public UserHeroService()
        {
            this.Db = new WoWArmoryDbContext();
        }
        public List<UsersHeroCardModel> ShowHeroCard(string currUser)
        {
            // List<UsersHeroCardModel> currUserHeroes = Db.Heroes
            //.Where(user => user.WoWUserName == currUser)
            //.Select(hero => new UsersHeroCardModel
            //{
            //    HeroName = hero.HeroName,
            //    HeroFaction = hero.HeroFaction,
            //    HeroRace = hero.HeroRace,
            //    HeroClass = hero.HeroClass,
            //    ClassDescription = GlobalHelperts.Global.descriptions
            //    .FirstOrDefault(x => x.Key == hero.HeroClass.ToString()).Value
            //}).ToList() ;


            return null;
            //return currUserHeroes;
        }
    }
}
