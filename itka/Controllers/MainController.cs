using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace itka.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public async Task<PartialViewResult> TopBarPartial()
        {
            return PartialView("TopBarPartial");
        }
    }
}