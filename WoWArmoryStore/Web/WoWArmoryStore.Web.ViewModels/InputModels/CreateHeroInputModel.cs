namespace WoWArmoryStore.Web.ViewModels
{
    using WoWArmory.Data.Models.Enum;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class CreateHeroInputModel : IMapFrom<Hero>
    {
        public string CurrUser { get; set; }

        public string HeroName { get; set; }

        public Faction HeroFaction { get; set; }

        public Race HeroRace { get; set; }

        public Class HeroClass { get; set; }
    }
}
