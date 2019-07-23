using WoWArmory.Data.Models;
using WoWArmory.Data.Models.Enum;
using WoWArmory.Models.InputModels;
using WoWArmory.Services.Data.Contracts;
namespace WoWArmory.Services.Data
{
    public class HeroService : IHeroService
    {
        public Hero Create(CreateHeroInputModel heroModel ,string currUser)
        {
            var hero = new Hero
            {
                WoWUserName = currUser,
                
                HeroName = heroModel.HeroName,
                HeroFaction = heroModel.HeroFaction,
                HeroRace = heroModel.HeroRace,
                HeroClass = heroModel.HeroClass
            };
            return hero;
        }
    }
}
