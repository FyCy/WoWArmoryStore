using System;
using WoWArmory.Data.Common.Models;
using WoWArmory.Data.Models.Enum;

namespace WoWArmory.Data.Models
{
    public class Post :BaseModel
    {
        public Post()
        {
           this.PostTime = DateTime.UtcNow;
        }
        public string WoWUserId { get; set; }
        public WoWUser WoWUser { get; set; }

        public string  Description { get; set; }

        public string ImageUrl { get; set; }

        public Tags Tags { get; set; }

        public DateTime PostTime { get; set; }
    }
}
