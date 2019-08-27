namespace WoWArmoryStore.Web.Areas.Administration.Controllers
{
    using WoWArmoryStore.Common;
    using WoWArmoryStore.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
