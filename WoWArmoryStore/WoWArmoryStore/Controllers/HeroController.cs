using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoWArmory.Models.InputModels;
using WoWArmory.Services.Data.Contracts;

namespace WoWArmoryStore.Controllers
{
    public class HeroController : BaseController
    {
        private readonly IHeroService heroService;
        public HeroController(IHeroService heroService)
        {
            this.heroService = heroService;
        }
        
        public  IActionResult NewHero()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult NewHero (CreateHeroInputModel model)
        {
            var hero = heroService.Create(model);

            Db.Heroes.Add(hero);
            Db.SaveChanges();

            return this.Redirect("/");
        }
    }
}