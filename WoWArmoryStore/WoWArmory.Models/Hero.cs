using WoWArmory.Data.Common.Models;
using WoWArmory.Data.Models.Enum;
using WoWArmory.Data.Models.Enum.Classes;

namespace WoWArmory.Data.Models
{
    public class Hero : BaseModel
    {
        public string WoWUserName { get; set; }
        public string HeroName { get; set; }
        public Faction HeroFaction { get; set; }
        public Race HeroRace { get; set; }
        public Class HeroClass { get; set; }
        
    }
}
