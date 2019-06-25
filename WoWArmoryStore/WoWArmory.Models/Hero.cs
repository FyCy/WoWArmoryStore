using WoWArmory.Data.Common.Models;
using WoWArmory.Data.Models.Enum;
using WoWArmory.Data.Models.Enum.Classes;

namespace WoWArmory.Data.Models
{
    public class Hero : BaseModel
    {
        public string WoWUserId { get; set; }
        public WoWUser WoWUser { get; set; }
        public Faction HeroFaction { get; set; }
        public Race HeroRace { get; set; }
        public Class HeroClass { get; set; }
        
    }
}
