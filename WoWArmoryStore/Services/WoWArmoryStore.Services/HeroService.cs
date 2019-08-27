namespace WoWArmoryStore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using WoWArmoryStore.Data;
    using WoWArmoryStore.Data.Models;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Models;
    using WoWArmoryStore.Web.ViewModels;

    public class HeroService : IHeroService
    {
        private readonly ApplicationDbContext contex;

        public HeroService(ApplicationDbContext contex)
        {
            this.contex = contex;
        }

        public void CreateNewHero(CreateHeroInputModel model, string user)
        {
            var hero = new Hero
            {
                HeroName = model.HeroName,
                HeroFaction = model.HeroFaction,
                HeroRace = model.HeroRace,
                HeroClass = model.HeroClass,
                WoWUserName = user,
            };

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "AllianceLogo",
            //    ImageUrl = "https://i.imgur.com/WODB9rf.jpg",
            //    Type = "Factions",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "HordeLogo",
            //    ImageUrl = "https://i.imgur.com/7iqPUVf.jpg",
            //    Type = "Factions",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "NightElfImage",
            //    ImageUrl = "https://i.imgur.com/dLk5edy.png",
            //    Type = "AllianceRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "WorgenImage",
            //    ImageUrl = "https://i.imgur.com/q1zT1M7.png",
            //    Type = "AllianceRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "PandarenImage",
            //    ImageUrl = "https://i.imgur.com/yzUlNQj.png",
            //    Type = "AllianceRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "DraeneiImage",
            //    ImageUrl = "https://i.imgur.com/n4dvMxw.png",
            //    Type = "AllianceRaces",
            //});


            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "GnomeImage",
            //    ImageUrl = "https://i.imgur.com/S15SnAM.png",
            //    Type = "AllianceRaces",
            //});


            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "DwarfImage",
            //    ImageUrl = "https://i.imgur.com/kuJqeUr.png",
            //    Type = "AllianceRaces",
            //});


            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "HumanImage",
            //    ImageUrl = "https://i.imgur.com/ikjsS8q.png",
            //    Type = "AllianceRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "PandarenImage",
            //    ImageUrl = "https://i.imgur.com/yzUlNQj.png",
            //    Type = "HordeRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "TaurenImage",
            //    ImageUrl = "https://i.imgur.com/ubdINpo.png",
            //    Type = "HordeRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "TrollImage",
            //    ImageUrl = "https://i.imgur.com/LIveTHt.png",
            //    Type = "HordeRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "UndeadImage",
            //    ImageUrl = "https://i.imgur.com/cnrU5FW.png",
            //    Type = "HordeRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "BloodElfImage",
            //    ImageUrl = "https://i.imgur.com/NYpVBfT.png",
            //    Type = "HordeRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "OrcImage",
            //    ImageUrl = "https://i.imgur.com/RIi0AFb.png",
            //    Type = "HordeRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "GoblinImage",
            //    ImageUrl = "https://i.imgur.com/MA29aM8.png",
            //    Type = "HordeRaces",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Rogue",
            //    ImageUrl = "https://i.imgur.com/LqQfBD4.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Hunter",
            //    ImageUrl = "https://i.imgur.com/okMkeQq.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Priest",
            //    ImageUrl = "https://i.imgur.com/abAGQAz.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Paladin",
            //    ImageUrl = "https://i.imgur.com/sCaYs3m.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "DeathKnight",
            //    ImageUrl = "https://i.imgur.com/TcqWyep.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Shaman",
            //    ImageUrl = "https://i.imgur.com/dWi7nAu.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Monk",
            //    ImageUrl = "https://i.imgur.com/0POPZ8e.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Warrior",
            //    ImageUrl = "https://i.imgur.com/gpccrg2.jpg",
            //    Type = "Class",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Mage",
            //    ImageUrl = "https://i.imgur.com/lxYtVjt.jpg",
            //    Type = "Class",
            //});
            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Druid",
            //    ImageUrl = "https://i.imgur.com/EiRxwuc.jpg",
            //    Type = "Class",
            //});
            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "DemonHunter",
            //    ImageUrl = "https://i.imgur.com/ACwULHR.jpg",
            //    Type = "Class",
            //});
            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Warlock",
            //    ImageUrl = "https://i.imgur.com/SpvEa2r.jpg",
            //    Type = "Class",
            //});
            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "BurningCrusade",
            //    ImageUrl = "https://i.imgur.com/BzgfnL6.jpg",
            //    Type = "CarouselImages",
            //});
            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "WrathofTheLichKing",
            //    ImageUrl = "https://i.imgur.com/MOtGyq2.jpg",
            //    Type = "CarouselImages",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Cataclysm",
            //    ImageUrl = "https://i.imgur.com/4jinU7x.jpg",
            //    Type = "CarouselImages",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "MistofPandaria",
            //    ImageUrl = "https://i.imgur.com/qyreQ81.jpg",
            //    Type = "CarouselImages",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "WarlordsOfDraenor",
            //    ImageUrl = "https://i.imgur.com/BKFB5rc.png",
            //    Type = "CarouselImages",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "Legion",
            //    ImageUrl = "https://i.imgur.com/ur7ecvP.jpg",
            //    Type = "CarouselImages",
            //});

            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "BattleOfAzeroth",
            //    ImageUrl = "https://i.imgur.com/y5oriY6.jpg",
            //    Type = "CarouselImages",
            //});
            this.contex.Heroes.Add(hero);
            this.contex.SaveChanges();
        }
    }
}
