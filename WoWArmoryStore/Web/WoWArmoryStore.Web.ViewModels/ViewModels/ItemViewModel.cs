namespace WoWArmoryStore.Web.ViewModels.ViewModels
{
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class ItemViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public string ImageUrl { get; set; }


    }
}
