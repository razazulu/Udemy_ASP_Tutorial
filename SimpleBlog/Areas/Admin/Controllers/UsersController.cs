using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTabAtrribute("users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}