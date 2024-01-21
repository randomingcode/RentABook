using Microsoft.EntityFrameworkCore;
using RentABook.Data;
using RentABook.Interfaces;
using RentABook.Models;

namespace RentABook.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Book book)
        {
            _context.Add(book);
            return Save();
        }

        public bool Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAllBooksByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
            //return await _context.Books.Include(a => a.Price).Where( c => c.Id == id).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool Update(Book book)
        {
            _context.Books.Update(book);
            return Save();
        }
    }
}
