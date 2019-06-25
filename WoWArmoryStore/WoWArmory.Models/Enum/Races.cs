using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Models.Enum
{
    public enum Races
    {
        Human = 1,
        Dwarf = 2,
        [Display(Name = "Night Elf")]
        NightElf = 3,
        Gnome = 4,
        Draenei = 5, 
        Worgen = 6 ,
        Pandaren = 7 ,
        Orc = 8 , 
        Undead = 9 , 
        Tauren = 10 , 
        Troll = 11,
        [Display(Name = "Blood Elf")]
        BloodElf = 12, 
        Goblin = 13, 
    }
}
