namespace WoWArmoryStore.Services.Models
{
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class HeroCreationImageModel : IMapFrom<Image>
    {
        public string ImageName { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }
    }
}
