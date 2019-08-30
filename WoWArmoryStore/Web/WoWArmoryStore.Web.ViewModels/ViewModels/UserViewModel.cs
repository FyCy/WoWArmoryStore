namespace WoWArmoryStore.Web.ViewModels.ViewModels
{
    using System.Collections.Generic;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class UserViewModel : IMapFrom<WoWArmoryUser>
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public ICollection<Hero> Heroes { get; set; }
    }
}
