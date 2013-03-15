using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Web.Model;

namespace Practice.Web.Journey.Controllers
{
    public class CarController : Controller
    {
        //
        // GET: /Car/

        public ActionResult Index()
        {
            return View();
        }

        private void PopulatePersonalDetailsReferenceData()
        {
            ViewBag.TitleTypes = TitleGender.GetTitleTypes();
        }
    }
}
