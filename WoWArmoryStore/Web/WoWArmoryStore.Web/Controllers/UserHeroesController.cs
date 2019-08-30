namespace WoWArmoryStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels.ViewModels;

    public class UserHeroesController : Controller
    {
        private readonly IUserHeroesService userHeroesService;
        private readonly IImageService imageService;

        public UserHeroesController(IUserHeroesService userHeroesService, IImageService imageService)
        {
            this.userHeroesService = userHeroesService;
            this.imageService = imageService;
        }

        public IActionResult UserHeroes()
        {
            var username = this.User.Identity.Name;
            var heroes = this.userHeroesService.UsersHeroes(username);
            if (heroes.Count == 0)
            {
                var image = this.imageService.GetImageUrls("Backgrounds", "NoHeroesBackground");
                return this.View("ZeroHeroesForCurrentUser", this.ViewBag.image = image[0]);
            }

            this.ViewBag.Heroes = heroes;
            return this.View();
        }

        public IActionResult DeleteHero(int id)
        {
            var currentUser = this.User.Identity.Name;

            this.userHeroesService.DeleteHero(currentUser, id);

            return this.RedirectToAction("UserHeroes");
        }
    }
}
