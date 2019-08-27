namespace WoWArmory.Data.Models.Enum.Classes
{
    using System.ComponentModel.DataAnnotations;

    public enum BloodElfClasses
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        [Display(Name = "Death Knight")]
        DeathKnight = 6,
        Mage = 7,
        Warlock = 8,
        Monk = 9,
        [Display(Name = "Demon Hunter")]
        DemonHunter = 10,
    }
}
