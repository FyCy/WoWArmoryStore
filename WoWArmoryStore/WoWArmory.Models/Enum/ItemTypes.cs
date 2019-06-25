using System.ComponentModel.DataAnnotations;

namespace WoWArmory.Data.Models.Enum
{
    public enum ItemTypes
    {
        Back = 1,
        Chest = 2,
        Feet = 3,
        Finger = 4,
        Hands = 5,
        Head = 6,
        [Display(Name = "Held In Off-Hand")]
        HeldInOffHand = 7,
        Legs = 8 , 
        Neck = 9 , 
        Shield = 10 , 
        Shirt = 11 , 
        Shoulder = 12, 
        Tabard = 13, 
        Trinket = 14, 
        Waist = 15 ,
        Wrist = 16 , 
    }
}
