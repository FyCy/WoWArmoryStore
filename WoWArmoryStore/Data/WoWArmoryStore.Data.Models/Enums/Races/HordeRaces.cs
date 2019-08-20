namespace WoWArmory.Data.Models.Enum.Races
{
    using System.ComponentModel.DataAnnotations;

    public enum HordeRaces
    {
        Orc = 1,
        Undead = 2,
        Tauren = 3,
        Troll = 4,
        [Display(Name = "Blood Elf")]
        BloodElf = 5,
        Goblin = 6,
        Pandaren = 7,
    }
}
