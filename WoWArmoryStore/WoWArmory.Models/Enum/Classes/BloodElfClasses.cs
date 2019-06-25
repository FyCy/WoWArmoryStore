using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Models.Enum.Classes
{
    public enum BloodElfClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        [Display(Name = "Demon Hunter")]
        DemonHunter = 2,
        Hunter = 3,
        Mage = 4,
        Monk = 5,
        Paladin = 6,
        Priest = 7,
        Rogue = 8,
        Warlock = 9,
        Warrior = 10


    }
}
