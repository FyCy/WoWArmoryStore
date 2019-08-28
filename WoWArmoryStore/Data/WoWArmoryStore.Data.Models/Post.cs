namespace WoWArmoryStore.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using WoWArmory.Data.Models.Enum;
    using WoWArmoryStore.Data.Common.Models;

    public class Post : BaseModel<int>, IDeletableEntity
    {
        public Post()
        {
            this.PostTime = DateTime.UtcNow;
        }

        [Required]
        public string WoWUserName { get; set; }

        [Required]
        public WoWArmoryUser WoWUser { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public Tags Tags { get; set; }

        [Required]
        public DateTime PostTime { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
