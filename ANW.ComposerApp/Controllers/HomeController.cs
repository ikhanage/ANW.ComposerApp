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
            return View(_composerDetailsHelper.GetComposersNames());
        }

        public ActionResult About(int composerId)
        {
            return View(_composerDetailsHelper.GetComposer(composerId));
        }
    }
}