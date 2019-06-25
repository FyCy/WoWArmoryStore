using System.Collections;
using System.Collections.Generic;
using WoWArmory.Data.Common.Models;

namespace WoWArmory.Data.Models
{
    public class Order : BaseModel
    {
        public Order()
        {
            this.Products = new List<Product>();
        }

        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }
       
    }
}
