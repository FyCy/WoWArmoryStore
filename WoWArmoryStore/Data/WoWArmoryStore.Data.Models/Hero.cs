namespace WoWArmoryStore.Data.Models
{
    using System;
    using System.Collections.Generic;

    using WoWArmory.Data.Models.Enum;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data.Common.Models;

    public class Hero : BaseModel<int>, IDeletableEntity
    {
        public Hero()
        {
            this.HeroItems = new HashSet<Product>();
        }

        public string WoWUserName { get; set; }

        public string HeroName { get; set; }

        public Faction HeroFaction { get; set; }

        public Race HeroRace { get; set; }

        public Class HeroClass { get; set; }

        public ICollection<Product> HeroItems { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
