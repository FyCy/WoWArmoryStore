using WoWArmory.Data.Common.Models;
using WoWArmory.Data.Models.Enum;

namespace WoWArmory.Data.Models
{
    public class Hero : BaseModel
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Faction HeroFaction { get; set; }
        public Races HeroRace { get; set; }
        public Classes HeroClass { get; set; }
        public AllowedWeapons AllowedWeapons { get; set; }
    }
}
