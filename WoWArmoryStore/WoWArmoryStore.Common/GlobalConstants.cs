namespace WoWArmoryStore.Common
{
    using System.Collections.Generic;

    public static class GlobalConstants
    {
       
        public const string AllianceLogo = @"https://imgs.tuts.dragoart.com/how-to-draw-alliance-alliance-world-of-warcraft_1_000000009327_5.jpg";
        public const string HordeLogo = @"https://images-na.ssl-images-amazon.com/images/I/61hb6a19mdL._SY550_.jpg";

        public static List<string> Factions => new List<string> { AllianceLogo, HordeLogo };

        public static List<string> AllianceClasses => new List<string> { HumanPicture, DwarfPicture, NightElfPicture, GnomePicture, DraeneiPicture, WorgenPicture, PandarenPicture };

        public static List<string> HordeClasses => new List<string> { OrcPicture, UndeadPicture, TaurenPicture, TrollPicture, BloodElfPicture, GoblinPicture, PandarenPicture };

        public static List<string> PandarenClassesPictures => new List<string> { MonkPicture, RougePicture, MagePicture, HunterPicture, PriestPicture, ShamanPicture, WarriorPicture };

        public static List<string> BloodElfClassesPictures => new List<string> { DeathKnightPicture, DemonHunterPicture, HunterPicture, MagePicture, MonkPicture, PaladinPicture, PriestPicture, RougePicture, WarlockPicture, WarriorPicture };

        public static List<string> DraeneiClassesPictures => new List<string> { DeathKnightPicture, HunterPicture, MonkPicture, MagePicture, PriestPicture, PaladinPicture, ShamanPicture, WarriorPicture };

        public static List<string> DwarfClassesPictures => new List<string> { DeathKnightPicture, HunterPicture, RougePicture, MonkPicture, MagePicture, WarlockPicture, PriestPicture, PaladinPicture, WarriorPicture, ShamanPicture };

        public static List<string> GnomeClassesPictures => new List<string> { DeathKnightPicture, HunterPicture, MonkPicture, PriestPicture, WarlockPicture, WarriorPicture, MagePicture, RougePicture };

        public static List<string> GoblinClassesPictures => new List<string> { DeathKnightPicture, HunterPicture, MagePicture, PriestPicture, RougePicture, WarriorPicture, WarlockPicture, ShamanPicture };

        public static List<string> HumanClassesPictures => new List<string> { DeathKnightPicture, HunterPicture, RougePicture, MonkPicture, MagePicture, WarlockPicture, PriestPicture, PaladinPicture, WarriorPicture };

        public static List<string> NightElfClassesPictures => new List<string> { DeathKnightPicture, DruidPicture, DemonHunterPicture, RougePicture, HunterPicture, MonkPicture, MagePicture, PriestPicture, WarriorPicture };

        public static List<string> OrcClassesPictures => new List<string> { DeathKnightPicture, MonkPicture, HunterPicture, MagePicture, RougePicture, WarlockPicture, ShamanPicture, WarriorPicture };

        public static List<string> TaurenClassesPictures => new List<string> { DeathKnightPicture, HunterPicture, DruidPicture, MonkPicture, PriestPicture, PaladinPicture, ShamanPicture, WarriorPicture };

        public static List<string> TrollClassesPictures => new List<string> { DeathKnightPicture, MonkPicture, HunterPicture, DruidPicture, MagePicture, PriestPicture, RougePicture, WarriorPicture, WarlockPicture, ShamanPicture };

        public static List<string> UndeadClassesPictures => new List<string> { DeathKnightPicture, HunterPicture, MagePicture, MonkPicture, PriestPicture, RougePicture, WarlockPicture, WarriorPicture };

        public static List<string> WorgenClassesPictures => new List<string> { DeathKnightPicture, DruidPicture, RougePicture, HunterPicture, MagePicture, PriestPicture, WarlockPicture, WarriorPicture };

        //Alliance race pictures        
        public const string HumanPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/VY868KR0EVQ41533927441456.png";
        public const string DwarfPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/DNJ3LJWA38671533927441195.png";
        public const string NightElfPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/N2IJPVUXVHAR1533927442157.png";
        public const string GnomePicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/H1J5NKKBA7AF1533927441238.png";
        public const string DraeneiPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/LEXYOLGGTTUS1533927440727.png";
        public const string WorgenPicture = @"http://bnetcmsus-a.akamaihd.net/cms/gallery/0V6056VVLQXE1533927442809.png";
        public const string PandarenPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/C27RNB06BJIR1533927442193.png";

        //Horde race pictures
        public const string OrcPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/JVPN9VNE0QNH1533927442123.png";
        public const string UndeadPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/P9XBFVWB6BS21533927442641.png";
        public const string TaurenPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/VSVY4RVDS3FX1533927442493.png";
        public const string TrollPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/QT9TVP4XPDP61533927442497.png";
        public const string BloodElfPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/3AB01HN47GVW1533927440397.png";
        public const string GoblinPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/B2OTWN3EDUXQ1533927440916.png";

        //Classes pictures
        public const string MonkPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_monk.jpg";
        public const string RougePicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_rogue.jpg";
        public const string HunterPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_hunter.jpg";
        public const string MagePicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_mage.jpg";
        public const string PriestPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_priest.jpg";
        public const string ShamanPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_shaman.jpg";
        public const string WarriorPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_warrior.jpg";
        public const string DeathKnightPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_death-knight.jpg";
        public const string DemonHunterPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_demon-hunter.jpg";
        public const string PaladinPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_paladin.jpg";
        public const string WarlockPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_warlock.jpg";
        public const string DruidPicture = @"https://blzmedia-a.akamaihd.net/wow/icons/56/class_druid.jpg";

        //Expansion pictures
        public const string TheBurningCrusade = @"https://stmed.net/sites/default/files/world-of-warcraft%3A-the-burning-crusade-hd-wallpapers-33913-1091723.jpg";
        public const string TheWrathoftheLichKing = @"https://wallpapercave.com/wp/ltjRnkg.jpg";
        public const string Cataclysm = @"https://stmed.net/sites/default/files/world-of-warcraft%3A-cataclysm-hd-wallpapers-33911-5523504.jpg";
        public const string MistsofPandaria = @"https://stmed.net/sites/default/files/world-of-warcraft%3A-mists-of-pandaria-hd-wallpapers-33912-3818927.jpg";
        public const string WarlordsofDraenor = @"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/b124b70f-071c-455b-b335-554774973608/d7yrvw0-43a5a427-f2b5-4d64-bd35-a8a6071bf3ee.png/v1/fill/w_1600,h_900,strp/warlords_of_draenor_wallpaper_____by_daerone_by_daerone_d7yrvw0-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9OTAwIiwicGF0aCI6IlwvZlwvYjEyNGI3MGYtMDcxYy00NTViLWIzMzUtNTU0Nzc0OTczNjA4XC9kN3lydncwLTQzYTVhNDI3LWYyYjUtNGQ2NC1iZDM1LWE4YTYwNzFiZjNlZS5wbmciLCJ3aWR0aCI6Ijw9MTYwMCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.9ukDUUhGxiwN3cZ9GQDDSJxI9eh-gElkjaiA71t2rp4";
        public const string Legion = @"http://getwallpapers.com/wallpaper/full/c/1/0/51322.jpg";
        public const string BattleforAzeroth = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/P563VGBMQ9Y21517347461170.jpg";

    public const string AdministratorRoleName = "Administrator";
    }
}
