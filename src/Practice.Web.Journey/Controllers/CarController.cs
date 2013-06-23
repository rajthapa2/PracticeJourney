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
            PopulateReferenceDataViewBag();
            return View();
        }

        #region Private

        private void PopulateReferenceDataViewBag()
        {
            PopulatePersonalDetailsReferenceData();
        }

        private void PopulatePersonalDetailsReferenceData()
        {
            ViewBag.TitleTypes = TitleGender.GetTitleTypes();
            ViewBag.DisplayTitles = TitleGender.GetDisplayTitles();
            ViewBag.MaritalStatusTypes = MaritalStatusGroup.GetMaritalTypes();
            ViewBag.DisplayMaritalStatus = MaritalStatusGroup.GetDisplayMaritalTypes();

        }

        #endregion
    }
}
