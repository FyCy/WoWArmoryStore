namespace WoWArmory.Data.Models.Enum.Races
{
    using System.ComponentModel.DataAnnotations;

    public enum AlianceRaces
    {
        Human = 1,
        Dwarf = 2,
        [Display(Name = "Night Elf")]
        NightElf = 3,
        Gnome = 4,
        Draenei = 5,
        Worgen = 6,
        Pandaren = 7,
    }
}
