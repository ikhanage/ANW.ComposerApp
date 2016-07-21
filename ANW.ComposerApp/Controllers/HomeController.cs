using ANW.ComposerApp.Interfaces;
using System.Web.Mvc;

namespace ANW.ComposerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IComposerDetailsHelper _composerDetailsHelper;
        public HomeController(IComposerDetailsHelper composerDetailsHelper)
        {
            _composerDetailsHelper = composerDetailsHelper;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}