using System.Collections;
using System.Collections.Generic;

namespace WoWArmory.Data.Models
{
    public class WoWGaG 
    {
        public WoWGaG()
        {
            this.Posts = new HashSet<Post>();
        }
        ICollection<Post> Posts { get; set; }
    }
}
