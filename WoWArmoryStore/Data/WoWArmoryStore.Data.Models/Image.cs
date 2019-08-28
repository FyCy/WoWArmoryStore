namespace WoWArmoryStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using WoWArmoryStore.Data.Common.Models;

    public class Image : BaseModel<int>
    {
        [Required]
        public string ImageName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
