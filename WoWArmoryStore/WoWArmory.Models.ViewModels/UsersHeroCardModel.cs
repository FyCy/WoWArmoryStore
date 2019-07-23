using WoWArmory.Data.Models.Enum;
using WoWArmory.Data.Models.Enum.Classes;

namespace WoWArmory.Models.ViewModels
{
    public class UsersHeroCardModel
    {
        public string HeroName { get; set; }

        public Faction HeroFaction { get; set; }

        public Race HeroRace { get; set; }

        public Class HeroClass { get; set; }

        public string ClassDescription { get; set; }
    }
}
