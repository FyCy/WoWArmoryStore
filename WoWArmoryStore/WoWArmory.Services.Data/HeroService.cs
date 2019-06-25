using System;
using WoWArmory.Data.Models;
using WoWArmory.Data.Models.Enum;
using WoWArmory.Models.InputModels;
using WoWArmory.Services.Data.Contracts;

namespace WoWArmory.Services.Data
{
    public class HeroService : IHeroService
    {
        
        public Hero Create(CreateHeroInputModel heroModel)
        {
            var hero = new Hero
            {
                HeroFaction = heroModel.HeroFaction,
                HeroRace = heroModel.HeroRace,
                HeroClass = heroModel.HeroClass
            };
            return hero;
        }
    }
}
