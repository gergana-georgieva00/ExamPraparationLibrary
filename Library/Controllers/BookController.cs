using Library.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : BaseController
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public async Task<IActionResult> Mine()
        {
            var model = await bookService.GetMyBooksAsync(GetUserId());

            return View(model);
        }

        public async Task<IActionResult> All()
        {
            var model = await bookService.GetAllBooksAsync();

            return View(model);
        }
    }
}
