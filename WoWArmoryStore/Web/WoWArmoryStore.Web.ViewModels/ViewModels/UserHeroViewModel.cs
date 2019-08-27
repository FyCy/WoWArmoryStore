namespace WoWArmoryStore.Web.ViewModels.ViewModels
{
    using System.Collections.Generic;
    using WoWArmory.Data.Models.Enum;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class UserHeroViewModel : IMapFrom<Hero>
    {
        public UserHeroViewModel()
        {
            this.HeroItems = new HashSet<Product>();
        }

        public string HeroName { get; set; }

        public Faction HeroFaction { get; set; }

        public Race HeroRace { get; set; }

        public Class HeroClass { get; set; }

        public ICollection<Product> HeroItems { get; set; }

    }
}
