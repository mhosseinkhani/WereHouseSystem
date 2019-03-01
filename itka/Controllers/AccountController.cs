using itka.Models;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using itka.Services;

namespace itka.Controllers
{
    public class AccountController : BaseController
    {

        public ActionResult Login()
        {
            if (TempData["Msg"] != null)
            {
                ViewBag.Msg = TempData["Msg"];
            }
            return View();
        }

  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(string username, string password)
        {

            var services = new MainServices();
            var user = await UserManager.FindAsync(username, password);
            var result = await SignInManager.PasswordSignInAsync(username, password, false, false);
            if (result == Microsoft.AspNet.Identity.Owin.SignInStatus.Success)
            {
                return RedirectToAction("Index", "App");

            }
//            else
            {
                TempData["Msg"] = "Username/Password Wrong";
                return RedirectToAction("Login");
            }

        }

       
        public ActionResult Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
              // register user here
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}