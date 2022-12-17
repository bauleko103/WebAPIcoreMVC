 
using HocWebAPICore.Models;

namespace HocWebAPICore.Repositories
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> getAllBookAsync();
        public Task<BookModel> getBookAsync(int id);
        public Task<int> AddBookAsync(BookModel model);
        public Task UpdateBookAsync(int id, BookModel model);
        public Task DeleteBookAsync(int id);


    }
}
