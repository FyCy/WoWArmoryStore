namespace WoWArmory.Data.Models.Enum.Classes
{
    using System.ComponentModel.DataAnnotations;

    public enum UndeadClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        Hunter = 2,
        Mage = 3,
        Monk = 4,
        Priest = 5,
        Rogue = 6,
        Warlock = 7,
        Warrior = 8,
    }
}
