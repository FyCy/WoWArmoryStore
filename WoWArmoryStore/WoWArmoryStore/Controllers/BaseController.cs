using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoWArmory.Data;

namespace WoWArmoryStore.Controllers
{
    public class BaseController : Controller
    {
        protected WoWArmoryDbContext Db { get; }
        public BaseController()
        {
            this.Db = new WoWArmoryDbContext();
        }

        public IActionResult Index()
        {
            //TODO Add ErrorViewModel
        //    object viewModel = new ErrorViewModel { Error = errorMessage };
        //    return this.View("CustomError", viewModel);
            return View();
        }
    }
}