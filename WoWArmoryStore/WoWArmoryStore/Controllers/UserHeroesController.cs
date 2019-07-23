using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WoWArmory.Services.Data.Contracts;

namespace WoWArmoryStore.Controllers
{
    public class UserHeroesController : BaseController
    {
        private readonly IUserHeroesService userHeroService;

        //public UserHeroesController(IUserHeroesService userHeroService)
        //{
        //    this.userHeroService = userHeroService;
        //}
        public IActionResult GetUserHeroes()
        {

            if (this.User.Identity.IsAuthenticated)
            {
                return this.View();
            }
            else
            {
                return this.Redirect("/Identity/Account/Login");
            }
        }
        [HttpGet]
        public IActionResult ShowHeroes()
        {
            var currentUser = this.User.Identity.Name;

           var herores =  userHeroService.ShowHeroCard(currentUser);
            


            return null;
        }
    }
}