﻿namespace WoWArmoryStore.Services.Contracts
{
    using System.Collections.Generic;
    using WoWArmoryStore.Services.Models;

    public interface IGetImageService
    {
        Dictionary<string, List<HeroCreationImageModel>> GetImages(string type);
    }
}
