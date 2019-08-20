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

<<<<<<< HEAD
            //this.contex.Images.Add(new Image
            //{
            //    ImageName = "MistOfPadaria",
            //    ImageUrl = "https://i.imgur.com/qyreQ81.jpg",
            //    Type = "CarouselImages",
            //});
=======
            this.contex.Images.Add(new Image
            {
                ImageName = "AllianceLogo",
                ImageUrl = "https://i.imgur.com/WODB9rf.jpg",
                Type = "HeroCreation",
            });
>>>>>>> parent of 1c8b8f4... New font. Added navbar button for settings. Images are in database.

            this.contex.Images.Add(new Image
            {
                ImageName = "HordeLogo",
                ImageUrl = "https://i.imgur.com/7iqPUVf.jpg",
                Type = "HeroCreation",
            });

            this.contex.Images.Add(new Image
            {
                ImageName = "HordeLogo",
                ImageUrl = "https://i.imgur.com/7iqPUVf.jpg",
                Type = "HeroCreation",
            });

            this.contex.Images.Add(new Image
            {
                ImageName = "BurningCrusade",
                ImageUrl = "https://i.imgur.com/BzgfnL6.jpg",
                Type = "HeroCreation",
            });
            this.contex.Images.Add(new Image
            {
                ImageName = "WrathoftheLichKing",
                ImageUrl = "https://i.imgur.com/4jinU7x.jpg",
                Type = "HeroCreation",
            });
            this.contex.Images.Add(new Image
            {
                ImageName = "Cataclysm",
                ImageUrl = "https://i.imgur.com/4jinU7x.jpg",
                Type = "HeroCreation",
            });
            this.contex.Images.Add(new Image
            {
                ImageName = "WarlordsofDraenor",
                ImageUrl = "https://i.imgur.com/BKFB5rc.png",
                Type = "HeroCreation",
            });
            this.contex.Images.Add(new Image
            {
                ImageName = "Legion",
                ImageUrl = "https://i.imgur.com/ur7ecvP.jpg",
                Type = "HeroCreation",
            });
            this.contex.Images.Add(new Image
            {
                ImageName = "BattleofAzeroth",
                ImageUrl = "https://i.imgur.com/y5oriY6.jpg",
                Type = "HeroCreation",
            });
            this.contex.Heroes.Add(hero);
            this.contex.SaveChanges();
        }
    }
}
