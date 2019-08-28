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
        private const string Classes = "Class";

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
                var classes = this.imageService.GetClassImageUrls(Classes);
                var factionImages = this.imageService.GetImageUrls(FactionImages);
                var allianceRacesImages = this.imageService.GetImageUrls(AllianceRaces);
                var hordeRacesImages = this.imageService.GetImageUrls(HordeRaces);

                this.ViewBag.Classes = classes;
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

        public JsonResult HeroCreation(CreateHeroInputModel model)
        {
            var currentUser = this.User.Identity.Name;

            this.heroService.CreateNewHero(model, currentUser.ToString());

            return this.Json(true);
        }
    }
}
