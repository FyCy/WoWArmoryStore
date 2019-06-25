using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Models.Enum.Races
{
    public enum HordeRaces
    {
        Pandaren = 1,
        Orc = 2,
        Undead = 3,
        Tauren = 4,
        Troll = 5,
        [Display(Name = "Blood Elf")]
        BloodElf = 6,
        Goblin =7
    }
}
