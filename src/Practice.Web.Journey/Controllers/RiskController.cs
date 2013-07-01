using System.Web.Mvc;
using Practice.Web.Model;

namespace Practice.Web.Journey.Controllers
{
    public class RiskController : Controller
    {
        public ActionResult SavePersonalDetails(PersonDetails personDetails)
        {
            var risk = new Risk(personDetails) {PersonDetails = personDetails};
            return Json(new {status = "OK"});
        }

        //public ActionResult SaveRisk()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
