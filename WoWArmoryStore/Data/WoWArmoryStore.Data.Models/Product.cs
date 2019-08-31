namespace WoWArmoryStore.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using WoWArmory.Data.Models.Enum;
    using WoWArmoryStore.Data.Common.Models;

    public class Product : BaseModel<int>, IDeletableEntity 
    {
        [Required]
        public string ItemName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        public bool Buyable { get; set; }

        [Required]
        public Materials ArmorMaterial { get; set; }


        [Required]
        public ItemTypes ItemSlots { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
