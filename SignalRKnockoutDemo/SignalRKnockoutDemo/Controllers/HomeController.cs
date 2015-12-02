using System.Web.Mvc;

namespace SignalRKnockoutDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sender()
        {
            return View();
        }

        public ActionResult Receiver()
        {
            return View();
        }
    }
}