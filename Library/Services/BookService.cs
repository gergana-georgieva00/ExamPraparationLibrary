using Library.Contracts;
using Library.Models;

namespace Library.Services
{
    public class BookService : IBookService
    {
        public Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }
    }
}
