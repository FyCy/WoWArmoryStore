using System;
using WoWArmory.Data.Common.Models;
using WoWArmory.Data.Models.Enum;
using Microsoft.AspNetCore.Identity;
namespace WoWArmory.Data.Models
{
    public class Post :BaseModel
    {
        public Post()
        {
           this.PostTime = DateTime.UtcNow;
        }
        public string WoWUserName { get; set; }
        public IdentityUser WoWUser { get; set; }

        public string  Description { get; set; }

        public string ImageUrl { get; set; }

        public Tags Tags { get; set; }

        public DateTime PostTime { get; set; }
    }
}
