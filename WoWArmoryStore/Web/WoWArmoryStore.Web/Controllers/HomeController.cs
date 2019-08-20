namespace WoWArmoryStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using WoWArmoryStore.Services.Contracts;
    using WoWArmoryStore.Services.Models;

    public class HomeController : BaseController
    {

        private readonly IGetImageService imageService;

        public HomeController(IGetImageService imageService)
        {
            this.imageService = imageService;
        }

        public IActionResult Index()
        {
            var type = "HeroCreation";
            var images = this.imageService.GetImages(type);
            Dictionary<string, List<HeroCreationImageModel>> img = new Dictionary<string, List<HeroCreationImageModel>>
            {            };
            this.ViewBag.Massage = img;
            return this.View();

        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View();
    }
}
