using System.Web.Mvc;
using SimpleBlog.ViewModel;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if(!ModelState.IsValid)
                return View(form);

            //Basic Validation
            /*if (form.Username != "test")
            {
                ModelState.AddModelError("Username", "Username or password isnt 20% cooler");
                return View(form);
            }*/

            return View(form);
        }
	}
}