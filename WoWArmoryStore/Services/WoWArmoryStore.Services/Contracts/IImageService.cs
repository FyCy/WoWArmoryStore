namespace WoWArmoryStore.Services.Contracts
{
    using System.Collections.Generic;
    using WoWArmoryStore.Services.Models;

    public interface IImageService
    {
        Dictionary<string, List<HeroCreationImageModel>> GetImages(string type);

        List<string> ImageUrls(string type);

        
    }
}
