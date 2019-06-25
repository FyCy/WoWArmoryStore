using WoWArmory.Data.Common.Models;
using WoWArmory.Data.Models.Enum;

namespace WoWArmory.Data.Models
{
    public class Product : BaseModel
    {
        public string Name  { get; set; }

        public string  Description { get; set; }

        public string  ImageUrl{ get; set; }

        public decimal  Price { get; set; }

        public bool  Buyable { get; set; }

        public int ItemLevel { get; set; }

        public Materials ArmorMaterial { get; set; }

        public int RequiredLevel { get; set; }

        public ItemTypes ItemSlots { get; set; }


    }
}
