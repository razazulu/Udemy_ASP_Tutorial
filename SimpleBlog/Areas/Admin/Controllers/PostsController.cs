using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTabAtrribute("posts")]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}