namespace WoWArmory.Data.Models.Enum.Races
{
    using System.ComponentModel.DataAnnotations;

    public enum AlianceRaces
    {
        Worgen = 1,
        [Display(Name = "Night Elf")]
        NightElf = 2,
        Pandaren = 3,
        Draenei = 4,
        Gnome = 5,
        Dwarf = 6,
        Human = 7,
    }
}
