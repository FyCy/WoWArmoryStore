namespace WoWArmoryStore.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels;

    public class HeroController : BaseController
    {

        private const string FactionImages = "Factions";
        private const string AllianceRaces = "AllianceRaces";
        private const string HordeRaces = "HordeRaces";

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

                var bloodElf = this.imageService.GetClassImageUrls("Class");
                this.ViewBag.BloodElf = bloodElf;


                var factionImages = this.imageService.GetImageUrls(FactionImages);
                var allianceRacesImages = this.imageService.GetImageUrls(AllianceRaces);
                var hordeRacesImages = this.imageService.GetImageUrls(HordeRaces);


                this.ViewBag.Faction = factionImages;
                this.ViewBag.AllianceRaces = allianceRacesImages;
                this.ViewBag.HordeRaces = hordeRacesImages;


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
