namespace WoWArmoryStore.Data.Models
{
    using System;

    using WoWArmory.Data.Models.Enum;
    using WoWArmoryStore.Data.Common.Models;

    public class Post : BaseModel<int>, IDeletableEntity
    {
        public Post()
        {
            this.PostTime = DateTime.UtcNow;
        }

        public string WoWUserName { get; set; }

        public WoWArmoryUser WoWUser { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Tags Tags { get; set; }

        public DateTime PostTime { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
