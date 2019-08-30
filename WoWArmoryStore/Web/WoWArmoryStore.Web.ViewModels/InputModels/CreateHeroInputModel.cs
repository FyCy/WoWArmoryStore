namespace WoWArmoryStore.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    using WoWArmory.Data.Models.Enum;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class CreateHeroInputModel : IMapFrom<Hero>
    {

        [Required]
        public string CurrUser { get; set; }

        [Required]
        public string HeroName { get; set; }

        [Required]
        public Faction HeroFaction { get; set; }

        [Required]
        public Race HeroRace { get; set; }

        [Required]
        public Class HeroClass { get; set; }
    }
}
