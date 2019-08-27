namespace WoWArmory.Data.Models.Enum.Classes
{
    using System.ComponentModel.DataAnnotations;

    public enum NightElfClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        Druid = 2,
        [Display(Name = "Demon Hunter")]
        DemonHunter = 3,
        Rogue = 4,
        Hunter = 5,
        Monk = 6,
        Mage = 7,
        Priest = 8,
        Warrior,
    }
}
