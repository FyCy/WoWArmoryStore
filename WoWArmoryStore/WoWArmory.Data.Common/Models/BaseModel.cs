using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Common.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
