namespace WoWArmoryStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Web.ViewModels.ViewModels;

    public class UserHeroesController : Controller
    {
        private readonly IUserHeroesService userHeroesService;

        public UserHeroesController(IUserHeroesService userHeroesService)
        {
            this.userHeroesService = userHeroesService;
        }

        public IActionResult UserHeroes()
        {
            var username = this.User.Identity.Name;
            var heroes = this.userHeroesService.UsersHeroes(username);
            this.ViewBag.Heroes = heroes;
            return this.View();
        }

        public JsonResult DeleteHero(UserHeroViewModel hero)
        {
            var currentUser = this.User.Identity.Name;

            this.userHeroesService.DeleteHero(currentUser, hero.HeroName);

            return this.Json(true);
        }
    }
}
