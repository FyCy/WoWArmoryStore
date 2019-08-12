namespace WoWArmoryStore.Data.Models
{
    using WoWArmoryStore.Data.Common.Models;

    public class Image : BaseModel<int>
    {
        public string ImageName { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }
    }
}
