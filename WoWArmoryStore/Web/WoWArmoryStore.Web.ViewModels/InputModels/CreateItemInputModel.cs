namespace WoWArmoryStore.Web.ViewModels.InputModels
{
    using System.ComponentModel.DataAnnotations;
    using WoWArmory.Data.Models.Enum;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Mapping;

    public class CreateItemInputModel : IMapFrom<Product>
    {
        [Required]
        public string ItemName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Materials ArmorMaterial { get; set; }

        [Required]
        public ItemTypes ItemSlots { get; set; }
    }
}
