namespace WoWArmory.Data.Models.Enum.Classes
{
    using System.ComponentModel.DataAnnotations;

    public enum TrollClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        Monk = 2,
        Hunter = 3,
        Druid = 4,
        Mage = 5,
        Priest = 6,
        Rogue = 7,
        Warlock = 8,
        Shaman = 9,
        Warrior = 10,
    }
}
