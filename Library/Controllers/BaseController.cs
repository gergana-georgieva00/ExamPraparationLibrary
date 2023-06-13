using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
