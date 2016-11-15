using System.Web.Mvc;

namespace ngcli_publicpath.Controllers
{
    public class HomeController : Controller
    {
        [Route("{*path}")]
        public ActionResult Index()
        {
            return File("~/Content/index.html", "text/html");
        }
    }
}