namespace WoWArmory.Data.Models.Enum.Races
{
    using System.ComponentModel.DataAnnotations;

    public enum HordeRaces
    {
        Pandaren = 1,
        Tauren = 2,
        Troll = 3,
        Undead = 4,
        [Display(Name = "Blood Elf")]
        BloodElf = 5,
        Orc = 6,
        Goblin = 7,
    }
}
