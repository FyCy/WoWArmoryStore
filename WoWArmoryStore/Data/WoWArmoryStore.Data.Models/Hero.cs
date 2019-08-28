namespace WoWArmoryStore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using WoWArmory.Data.Models.Enum;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data.Common.Models;

    public class Hero : BaseModel<int>, IDeletableEntity
    {
        public Hero()
        {
            this.HeroItems = new HashSet<Product>();
        }

        [Required]
        public string WoWUserName { get; set; }

        [Required]
        public string HeroName { get; set; }

        [Required]
        public Faction HeroFaction { get; set; }

        [Required]
        public Race HeroRace { get; set; }

        [Required]
        public Class HeroClass { get; set; }

        public ICollection<Product> HeroItems { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
