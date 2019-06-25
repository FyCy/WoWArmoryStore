using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Models.Enum.Classes
{
    public enum TaurenClasses
    {
        [Display(Name = "Death Knight")]
        DeathKnight = 1,
        Hunter = 2,
        Druid = 3,
        Monk = 4,
        Priest = 5,
        Paladin = 6,
        Shaman = 7,
        Warrior = 8
    }
}
