using System.Collections;
using System.Collections.Generic;
using WoWArmory.Data.Common.Models;
using Microsoft.AspNetCore.Identity;
namespace WoWArmory.Data.Models
{
    public class Order : BaseModel
    {
        public Order()
        {
            this.Products = new List<Product>();
        }

        public string WoWUserId { get; set; }
        public IdentityUser WoWUser { get; set; }

        public ICollection<Product> Products { get; set; }
       
    }
}
