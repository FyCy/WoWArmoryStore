namespace WoWArmory.Data.Models.Enum.Classes
{
    using System.ComponentModel.DataAnnotations;

    public enum GnomeClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        Hunter = 2,
        Monk = 3,
        Priest = 4,
        Warlock = 5,
        Warrior = 6,
        Mage = 7,
        Rogue = 8,
    }
}
