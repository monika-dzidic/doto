using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CatchAllController : Controller
    {
        public IActionResult Index()
        {
            return File("~/index.html", "text/html");
        }
    }
}