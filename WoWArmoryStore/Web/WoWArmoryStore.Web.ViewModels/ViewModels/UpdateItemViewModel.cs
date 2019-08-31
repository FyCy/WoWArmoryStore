namespace WoWArmoryStore.Web.ViewModels.ViewModels
{
    using WoWArmory.Data.Models.Enum;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class UpdateItemViewModel : IMapFrom<Product>
    {
        public string ItemName { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Materials ArmorMaterial { get; set; }

        public ItemTypes ItemSlots { get; set; }
    }
}
