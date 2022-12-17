using AutoMapper;
using HocWebAPICore.Data;
using HocWebAPICore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HocWebAPICore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly HocWebAPICoreContext _context;
        private readonly IMapper _mapper;
        public BookRepository(HocWebAPICoreContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<int> AddBookAsync(BookModel model)
        {
            var newBook=_mapper.Map<Book>(model);
            _context.Book!.Add(newBook);
            await _context.SaveChangesAsync();
            return newBook.id;
           
        }

        public async Task DeleteBookAsync(int id)
        {
            var bookDel = _context.Book!.SingleOrDefault(b => b.id == id);
           
            if(bookDel != null) _context.Book!.Remove(bookDel);await _context.SaveChangesAsync();

        }
        [HttpGet]
        public async Task<List<BookModel>> getAllBookAsync()
        {
            var book=await _context.Book!.ToListAsync();
            return _mapper.Map<List<BookModel>>(book);
        }
        
        
        public async Task<BookModel> getBookAsync(int id)
        {
            var book = await _context.Book.FindAsync(id);
            return _mapper.Map<BookModel>(book);    
            
        }

        public async Task UpdateBookAsync(int id, BookModel model)
        {
            if(id== model.id)
            {
                var updateBook = _mapper.Map<Book>(model);
                _context.Book!.Update(updateBook);
                await _context.SaveChangesAsync();

            }
            throw new NotImplementedException();
        }
    }
}
