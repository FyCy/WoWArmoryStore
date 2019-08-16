namespace WoWArmoryStore.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels;

    public class HeroController : BaseController
    {
        private readonly IHeroService heroService;
        private readonly IImageService imageService;

        public HeroController(IHeroService heroService, IImageService imageService)
        {
            this.heroService = heroService;
            this.imageService = imageService;
        }

        [HttpGet]
        public IActionResult Faction(string classType)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                string faction = "Factions";
                string allianceRaces = "AllianceRaces";
                string hordeRaces = "HordeRaces";

                var factionImages = this.imageService.ImageUrls(faction);
                var allianceRacesImages = this.imageService.ImageUrls(allianceRaces);
                var hordeRacesImages = this.imageService.ImageUrls(hordeRaces);

                var bloodElf = this.imageService.ImageUrls("BloodElf");

                this.ViewBag.Faction = factionImages;
                this.ViewBag.AllianceRaces = allianceRacesImages;
                this.ViewBag.HordeRaces = hordeRacesImages;
                this.ViewBag.BloodElf = bloodElf;


                return this.View();
            }
            else
            {
                return this.Redirect("/Identity/Account/Login");
            }
        }

        [HttpPost]
        public IActionResult HeroCreation(CreateHeroInputModel model)
        {
            var currentUser = this.User.Identity.Name;

            this.heroService.CreateNewHero(model, currentUser.ToString());

            return this.View("/");
        }
    }
}
