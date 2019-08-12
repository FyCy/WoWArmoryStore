namespace WoWArmoryStore.Data.Models
{
    using System;

    using WoWArmory.Data.Models.Enum;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data.Common.Models;

    public class Hero : BaseModel<int>, IDeletableEntity
    {
        public string WoWUserName { get; set; }

        public string HeroName { get; set; }

        public Faction HeroFaction { get; set; }

        public Race HeroRace { get; set; }

        public Class HeroClass { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
