using System.Collections.Generic;

namespace WoWArmoryStore.Helpers
{
    public class GlobalConstants
    {
        public const string AllianceLogo = @"https://wallpaperplay.com/walls/full/e/a/e/41114.jpg";
        public const string HordeLogo = @"https://images-na.ssl-images-amazon.com/images/I/61hb6a19mdL._SY550_.jpg";

        public static List<string> Factions => new List<string> { AllianceLogo, HordeLogo };
        public GlobalConstants()
        {
            Factions.Add(AllianceLogo);
            Factions.Add(HordeLogo);
        }
        public const string HumanPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/VY868KR0EVQ41533927441456.png";
        public const string DwarfPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/DNJ3LJWA38671533927441195.png";
        public const string NightElfPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/N2IJPVUXVHAR1533927442157.png";
        public const string GnomePicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/H1J5NKKBA7AF1533927441238.png";
        public const string PandarenPicture = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/C27RNB06BJIR1533927442193.png";

        public const string TheBurningCrusade = @"https://stmed.net/sites/default/files/world-of-warcraft%3A-the-burning-crusade-hd-wallpapers-33913-1091723.jpg";
        public const string TheWrathoftheLichKing = @"https://wallpapercave.com/wp/ltjRnkg.jpg";
        public const string Cataclysm = @"https://stmed.net/sites/default/files/world-of-warcraft%3A-cataclysm-hd-wallpapers-33911-5523504.jpg";
        public const string MistsofPandaria = @"https://stmed.net/sites/default/files/world-of-warcraft%3A-mists-of-pandaria-hd-wallpapers-33912-3818927.jpg";
        public const string WarlordsofDraenor = @"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/b124b70f-071c-455b-b335-554774973608/d7yrvw0-43a5a427-f2b5-4d64-bd35-a8a6071bf3ee.png/v1/fill/w_1600,h_900,strp/warlords_of_draenor_wallpaper_____by_daerone_by_daerone_d7yrvw0-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9OTAwIiwicGF0aCI6IlwvZlwvYjEyNGI3MGYtMDcxYy00NTViLWIzMzUtNTU0Nzc0OTczNjA4XC9kN3lydncwLTQzYTVhNDI3LWYyYjUtNGQ2NC1iZDM1LWE4YTYwNzFiZjNlZS5wbmciLCJ3aWR0aCI6Ijw9MTYwMCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.9ukDUUhGxiwN3cZ9GQDDSJxI9eh-gElkjaiA71t2rp4";
        public const string Legion = @"http://getwallpapers.com/wallpaper/full/c/1/0/51322.jpg";
        public const string BattleforAzeroth = @"https://bnetcmsus-a.akamaihd.net/cms/gallery/P563VGBMQ9Y21517347461170.jpg";

    }
}
