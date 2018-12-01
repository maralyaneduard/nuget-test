using LoggerEMN;
using System.Web.Mvc;

namespace testApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Logger logger = new Logger();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}