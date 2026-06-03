using System.Web.Mvc;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello ASP.NET MVC";
            return View();
        }
    }
}