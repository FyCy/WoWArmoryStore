namespace WoWArmoryStore.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WoWArmory.Data.Models.Enum.Classes;
    using WoWArmoryStore.Data;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Mapping;
    using WoWArmoryStore.Services.Models;

    public class GetImageService : IImageService
    {
        private readonly ApplicationDbContext db;

        private readonly Dictionary<string, List<HeroCreationImageModel>> images;

        public GetImageService(ApplicationDbContext contex)
        {
            this.db = contex;
            this.images = new Dictionary<string, List<HeroCreationImageModel>>();
        }

        public Dictionary<string, string> GetClassImageUrls(string type)
        {
            var classImages = this.db.Images.Where(x => x.Type == type).To<HeroCreationImageModel>().ToList();
            var imgs = new Dictionary<string, string>();
            foreach (var item in classImages)
            {
                imgs.Add(item.ImageName, item.ImageUrl);
            }

            return imgs;
        }

        public List<string> GetImageUrls(string type)
        {
            var currImages = this.db.Images.Where(x => x.Type == type).To<HeroCreationImageModel>().ToList();
            this.images.Add(type, currImages);

            var imageUrls = new List<string>();
            foreach (var imageLists in this.images)
            {
                if (imageLists.Key.ToString() == type)
                {
                    foreach (var values in imageLists.Value)
                    {
                        imageUrls.Add(values.ImageUrl);
                    }
                }
            }

            return imageUrls;
        }
    }
}
