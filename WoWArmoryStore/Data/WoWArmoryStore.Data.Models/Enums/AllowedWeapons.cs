namespace WoWArmory.Data.Models.Enum
{
    using System.ComponentModel.DataAnnotations;

    public enum Weapons
    {
        [Display(Name = "One Handed Axe")]
        OneHandedAxe = 1,
        [Display(Name = "Two Handed Axe")]
        TwoHandedAxe = 3,
        Crossbow = 4,
        Dagger = 5,
        [Display(Name = "Fishing Pole")]
        FishingPole = 6,
        [Display(Name = "Fist Weapon")]
        FistWeapon = 7,
        Gun = 8,
        [Display(Name = "One Handed Mace")]
        OneHandedHandMace = 9,
        [Display(Name = "Two Handed Mace")]
        TwoHandedMace = 10,
        Polearm = 11,
        Stave = 12,
        [Display(Name = "One Handed Sword")]
        OneHandedSword = 13,
        [Display(Name = "Two Handed Sword")]
        TwoHandedSword = 14,
        [Display(Name = "Thrown Weapon")]
        ThrownWeapon = 15,
        Wand = 16,
    }
}
