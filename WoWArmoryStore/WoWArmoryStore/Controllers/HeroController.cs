using Microsoft.AspNetCore.Mvc;
using WoWArmory.Models.InputModels;
using WoWArmory.Services.Data.Contracts;

namespace WoWArmoryStore.Controllers
{
    public class HeroController : BaseController
    {
        private readonly IHeroService heroService;
       

        //private readonly currentUserName = currentuser
        public HeroController(IHeroService heroService)
        {
            this.heroService = heroService;
        }
       
        public  IActionResult Faction()
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
        [HttpPost]
        public IActionResult Faction ([FromBody]CreateHeroInputModel model)
        {
           
                var currentUser = this.User.Identity.Name;
                var hero = heroService.Create(model, currentUser);


                Db.Heroes.Add(hero);
                Db.SaveChanges();
            //return new JsonResult(hero);
            return this.Redirect("/");
        }
    }
}