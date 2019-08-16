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
            //    ImageName = "Monk",
            //    ImageUrl = "https://i.imgur.com/0POPZ8e.jpg",
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
            //    ImageName = "Pandaren",
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
            this.contex.Heroes.Add(hero);
            this.contex.SaveChanges();
        }
    }
}
