using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WoWArmory.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Heroes = new HashSet<Hero>();
            this.Posts = new HashSet<Post>();
            this.Orders = new HashSet<Order>();
            this.Products = new HashSet<Product>();
        }

        public ICollection<Hero> Heroes { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Post> Posts { get; set; }
        //MAYBE USELESSS
        public ICollection<Product> Products { get; set; }
    }
}
