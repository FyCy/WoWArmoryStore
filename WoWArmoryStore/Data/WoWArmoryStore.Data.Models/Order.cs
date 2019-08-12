namespace WoWArmoryStore.Data.Models
{
    using System;
    using System.Collections.Generic;

    using WoWArmoryStore.Data.Common.Models;

    public class Order : BaseModel<int>, IDeletableEntity
    {
        public Order()
        {
            this.Products = new List<Product>();
        }

        public string WoWUserName { get; set; }

        public WoWArmoryUser WoWArmoryUser { get; set; }

        public ICollection<Product> Products { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
