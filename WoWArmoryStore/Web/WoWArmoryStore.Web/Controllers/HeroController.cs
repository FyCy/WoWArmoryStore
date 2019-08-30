namespace WoWArmoryStore.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using WoWArmoryStore.Data.Models;
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
        private readonly UserManager<WoWArmoryUser> userManager;
        public HeroController(IHeroService heroService, IImageService imageService, UserManager<WoWArmoryUser> userManager)
        {
            this.heroService = heroService;
            this.imageService = imageService;
            this.userManager = userManager;
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
            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            this.heroService.CreateNewHero(model, currentUser.ToString(),  userId);

            return this.Json(true);
        }
    }
}
