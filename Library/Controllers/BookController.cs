using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : BaseController
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult All()
        {
            return View();
        }
    }
}
