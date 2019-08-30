namespace WoWArmoryStore.Services.Contracts
{
    using System.Collections.Generic;

    public interface IImageService
    {
        List<string> GetImageUrls(string type);


        List<string> GetImageUrls(string type, string name);

        Dictionary<string, string> GetClassImageUrls(string type);
    }
}
