using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
