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

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
        private readonly UserManager<WoWArmoryUser> userManager;
        private readonly IAdministrationService administrationService;
        private readonly IImageService imageService;

        public AdministrationController(UserManager<WoWArmoryUser> userManager, IAdministrationService administrationService, IImageService imageService)
        {
            this.userManager = userManager;
            this.administrationService = administrationService;

            this.imageService = imageService;
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
                return this.View("ZeroUsers", this.ViewBag.image = image[0]);
            }
            this.ViewBag.Users = users;
            return this.View();
        }

        public IActionResult DeleteUser(string id)
        {

            this.administrationService.DeleteUser(id);

            return this.RedirectToAction("UsersTable");
        }
    }
}
