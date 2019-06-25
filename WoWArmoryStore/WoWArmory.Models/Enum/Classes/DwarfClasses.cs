using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Models.Enum.Classes
{
    public enum DwarfClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        Hunter = 2,
        Rogue = 3,
        Monk = 4,
        Mage = 5,
        Warlock = 6,
        Priest = 7,
        Paladin = 8,
        Warrior = 9,
        Shaman = 10
    }
}
