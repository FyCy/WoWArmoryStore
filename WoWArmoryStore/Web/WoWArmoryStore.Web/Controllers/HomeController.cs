namespace WoWArmoryStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WoWArmoryStore.Services.Contracts;

    public class HomeController : BaseController
    {
        private readonly IImageService imageService;

        public HomeController(IImageService imageService)
        {
            this.imageService = imageService;
        }

        public IActionResult Index()
        {
            var images = this.imageService.GetImageUrls("CarouselImages");
            this.ViewBag.ExpansionImages = images;
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
