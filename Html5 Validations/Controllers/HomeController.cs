using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Html5_Validations.Models;

namespace Html5_Validations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new UserProfileModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(UserProfileModel model)
        {
           
            return RedirectToAction("Index");
        }
    }
}