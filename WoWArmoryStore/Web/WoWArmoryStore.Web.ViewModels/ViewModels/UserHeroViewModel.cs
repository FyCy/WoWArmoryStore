namespace WoWArmoryStore.Web.ViewModels.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using WoWArmory.Data.Models.Enum;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class UserHeroViewModel : IMapFrom<Hero>, IMapTo<Hero>
    {
        public UserHeroViewModel()
        {
            this.HeroItems = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        public string HeroName { get; set; }

        [Required]
        public Faction HeroFaction { get; set; }

        [Required]
        public Race HeroRace { get; set; }

        [Required]
        public Class HeroClass { get; set; }

        [Required]
        public ICollection<Product> HeroItems { get; set; }

    }
}
