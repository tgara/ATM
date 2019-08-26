using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        // Get /home/index
  
        public ActionResult Index()
        {
            return View();
        }

        // Get /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // Get /home/contact
        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Est ce que vous avez des problemes";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Foo()
        {
            return PartialView("about");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNET";

            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            // return new HttpStatusCodeResult(403);
            // return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            return RedirectToRoute("Index");
        }
    }
}