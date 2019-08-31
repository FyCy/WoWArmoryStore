namespace WoWArmoryStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ShopController : Controller
    {
        public IActionResult ShopIndex()
        {
            return this.View();
        }
    }
}
