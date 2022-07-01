using System.Web.Mvc;

namespace Minem.Sgpam.WebApiLF.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return Json("WEB API - SIGEPAM LF", JsonRequestBehavior.AllowGet);
        }
    }
}