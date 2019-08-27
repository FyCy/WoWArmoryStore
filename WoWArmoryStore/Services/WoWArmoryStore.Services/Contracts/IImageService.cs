namespace WoWArmoryStore.Services.Contracts
{
    using System.Collections.Generic;

    public interface IImageService
    {
        List<string> GetImageUrls(string type);

        Dictionary<string, string> GetClassImageUrls(string type);
    }
}
