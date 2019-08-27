namespace WoWArmory.Data.Models.Enum.Classes
{
    using System.ComponentModel.DataAnnotations;

    public enum GoblinClasses
    {
        [Display(Name = "Demon Hunter")]
        DeathKnight = 1,
        Hunter = 2,
        Mage = 3,
        Priest = 4,
        Rogue = 5,
        Warlock = 6,
        Shaman = 7,
        Warrior = 8,
    }
}
