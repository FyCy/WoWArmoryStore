﻿using WoWArmory.Data.Models.Enum;
using WoWArmory.Data.Models.Enum.Classes;

namespace WoWArmory.Models.InputModels
{
    public class CreateHeroInputModel
    {
        
        public string HeroName { get; set; }
        public Faction HeroFaction { get; set; }
        public Race HeroRace { get; set; }

        public Class HeroClass { get; set; }
    

    }
}
