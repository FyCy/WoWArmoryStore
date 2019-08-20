namespace WoWArmoryStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Models;
    using WoWArmoryStore.Web.ViewModels;
    using static System.Net.Mime.MediaTypeNames;

    public class HeroController : BaseController
    {
        private readonly IHeroService heroService;
        private readonly IGetImageService imageService;

        public HeroController(IHeroService heroService, IGetImageService imageService)
        {
            this.heroService = heroService;
            this.imageService = imageService;
        }

        public IActionResult Faction()
        {
            var type = "HeroCreation";
            if (this.User.Identity.IsAuthenticated)
            {
                var images = this.imageService.GetImages(type);

                var ass = new List<HeroCreationImageModel>();
                var dic = new Dictionary<string, string>();

                foreach (var item in images)
                {
                    var g = item.Value;
                    for (int i = 0; i < g.Count; i++)
                    {
                        var s = g[i];
                        dic.Add(s.ImageName, s.ImageUrl);
                    }
                }
                var a = dic.FirstOrDefault(x => x.Key == "AllianceLogo");
                var h = dic.FirstOrDefault(x => x.Key == "HordeLogo");
                ViewBag.AllianceLogo = a.Value;
                ViewBag.HordeLogo = h.Value;
                ViewBag.dictionaryu = dic;
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
