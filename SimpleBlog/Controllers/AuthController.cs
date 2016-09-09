using System.Web.Mvc;
using System.Web.Security;
using SimpleBlog.ViewModel;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if(!ModelState.IsValid)
                return View(form);

            //Basic Validation
            /*if (form.Username != "test")
            {
                ModelState.AddModelError("Username", "Username or password isnt 20% cooler");
                return View(form);
            }*/

            //Authorisation - Is the person who he said he is
            FormsAuthentication.SetAuthCookie(form.Username, true);

            //Check we are redirecting to different domain for security purposes
            if (!string.IsNullOrWhiteSpace(returnUrl))
                return Redirect(returnUrl);

            return RedirectToRoute("home");
            
        }
	}
}