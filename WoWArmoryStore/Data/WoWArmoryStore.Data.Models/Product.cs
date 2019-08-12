namespace WoWArmoryStore.Data.Models
{
    using System;

    using WoWArmory.Data.Models.Enum;
    using WoWArmoryStore.Data.Common.Models;

    public class Product : BaseModel<int>, IDeletableEntity
    {
        public string ItemName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public bool Buyable { get; set; }

        public int ItemLevel { get; set; }

        public Materials ArmorMaterial { get; set; }

        public int RequiredLevel { get; set; }

        public ItemTypes ItemSlots { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
