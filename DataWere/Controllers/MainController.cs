using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataWere.Controllers
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