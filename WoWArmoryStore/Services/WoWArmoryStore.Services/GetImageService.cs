namespace WoWArmoryStore.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using WoWArmoryStore.Data;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Models;
    using WoWArmoryStore.Services.Mapping;
    using WoWArmory.Data.Models.Enum.Classes;

    using System;

    using WoWArmory.Data.Models.Enum;

    public class GetImageService : IImageService
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

        public List<string> ImageUrls(string type)
        {
            List<string> imageUrls = new List<string>();
            var images = this.GetImages(type);
            var classes = this.GetImages("Class");
            string raceClassesName = type + "Classes";

            var wantedClasses = Enum.GetValues(typeof(BloodElfClasses)).Cast<BloodElfClasses>().Select(v => v.ToString()).ToList();
            var allClasses = Enum.GetValues(typeof(Class)).Cast<Class>().Select(v => v.ToString()).ToList();
            var allRaces = Enum.GetValues(typeof(Race)).Cast<Race>().Select(v => v.ToString()).ToList();
            if (allRaces.Contains(type))
            {
                foreach (var firstClass in allClasses)
                {
                    foreach (var secondClass in wantedClasses)
                    {
                        if (firstClass.ToString() == secondClass.ToString())
                        {
                            foreach (var currClass in classes)
                            {
                                var c = currClass.Value;
                                for (int i = 0; i < c.Count(); i++)
                                {
                                    if (c[i].ImageName == firstClass.ToString())
                                    {
                                        imageUrls.Add(c[i].ImageUrl);
                                        break;
                                    }
                                }
                            }

                            break;
                        }
                    }
                }
            }

            foreach (var img in images)
            {
                var key = img.Value;
                for (int i = 0; i < key.Count; i++)
                {
                    var s = key[i];
                    imageUrls.Add(s.ImageUrl);
                }
            }

            return imageUrls;
        }
    }
}
