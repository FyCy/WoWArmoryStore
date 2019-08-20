namespace WoWArmoryStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WoWArmoryStore.Services.Contracts;

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
    }
}