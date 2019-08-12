namespace WoWArmoryStore.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using WoWArmoryStore.Data;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Models;
    using WoWArmoryStore.Services.Mapping;

    public class GetImageService : IGetImageService
    {
        private readonly ApplicationDbContext db;

        public GetImageService(ApplicationDbContext contex)
        {
            this.db = contex;
        }

        public Dictionary<string, List<HeroCreationImageModel>> GetImages(string type)
        {
            Dictionary<string, List<HeroCreationImageModel>> images = new Dictionary<string, List<HeroCreationImageModel>>();

            var listOfImages = this.db.Images.Where(img => img.Type == type).To<HeroCreationImageModel>().ToList();

            images.Add("Factions", listOfImages);
            return images;
        }
    }
}
