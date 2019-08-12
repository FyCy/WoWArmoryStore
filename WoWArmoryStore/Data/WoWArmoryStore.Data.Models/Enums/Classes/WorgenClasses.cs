namespace WoWArmory.Data.Models.Enum.Classes
{
    using System.ComponentModel.DataAnnotations;

    public enum WorgenClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        Druid = 2,
        Rogue = 3,
        Hunter = 4,
        Mage = 5,
        Priest = 6,
        Warlock = 7,
        Warrior = 8,
    }
}
