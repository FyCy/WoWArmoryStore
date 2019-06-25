using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Models.Enum
{
    public enum Classes
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        [Display(Name = "Death Knight")]
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Monk = 10,
        Druid = 11,
        [Display(Name = "Demon Hunter")]
        DemonHunter = 12
    }
}

