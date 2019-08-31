namespace WoWArmoryStore.Web.Areas.Administration.Controllers
{
    using WoWArmoryStore.Common;
    using WoWArmoryStore.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;
    using WoWArmoryStore.Data.Models;
    using System.Threading.Tasks;
    using WoWArmoryStore.Services.Contracts;
    using System.Security.Claims;
    using WoWArmoryStore.Common;
    using WoWArmoryStore.Web.ViewModels.InputModels;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
        private readonly UserManager<WoWArmoryUser> userManager;
        private readonly IAdministrationService administrationService;
        private readonly IImageService imageService;
        private readonly IItemService itemService;

        public AdministrationController(UserManager<WoWArmoryUser> userManager, IAdministrationService administrationService, IImageService imageService, IItemService itemService)
        {
            this.userManager = userManager;
            this.administrationService = administrationService;
            this.imageService = imageService;
            this.itemService = itemService;
        }


        public async Task<IActionResult> CreateRole()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            await this.userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);

            return this.Ok();
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult UsersTable()
        {
            var userId = this.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var users = this.administrationService.UserViewModels(userId);
            if (users.Count == 0)
            {
                var image = this.imageService.GetImageUrls("Backgrounds", "NoUsersBackGround");
                return this.View("ZeroUsers");
            }

            this.ViewBag.Users = users;
            return this.View();
        }

        public IActionResult DeleteUser(string id)
        {
            this.administrationService.DeleteUser(id);

            return this.RedirectToAction("UsersTable");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult CreateItem()
        {
            return this.View();
        }

        public JsonResult AddItem(CreateItemInputModel model)
        {
            this.itemService.CreateNewItem(model);

            return this.Json(true);
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult ItemsTable()
        {
           
            var items = this.administrationService.ItemViewModels();
            if (items.Count == 0)
            {
                var image = this.imageService.GetImageUrls("Backgrounds", "NoUsersBackGround");
                return this.View("ZeroItems");
            }

            this.ViewBag.Items = items;
            return this.View();
        }

        public IActionResult DeleteItem(int id)
        {
            this.administrationService.DeleteItem(id);

            return this.RedirectToAction("ItemsTable");
        }

        public IActionResult UpdateItem(int id)
        {
            var item = this.administrationService.GetItemToUpdate(id);
            this.ViewBag.ItemToUpdate = item;
            return this.View(item);
        }

        [HttpPost]
        public IActionResult UpdateItem(Product model)
        {
            this.administrationService.UpdateItem(model);
            return this.RedirectToAction("ItemsTable");
        }
    }
}
