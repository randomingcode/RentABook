using Microsoft.EntityFrameworkCore;
using RentABook.Data;
using RentABook.Interfaces;
using RentABook.Models;

namespace RentABook.Repository
{
    public class BookRepository : IBookRepository
    {
        private  ApplicationDbContext _context;
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
            _context.Remove(book.Price);
            _context.Remove(book);
            
            return Save();
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.Include(a => a.Price).ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooksByAuthor(string author)
        {
            return await _context.Books.Include(x => x.Price).Where(a => a.Author == author).ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Books.Include(a => a.Price).FirstOrDefaultAsync(c => c.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool Update(Book book)
        {
            //_context.Prices.Update(book.Price);
            _context.Books.Update(book);
            return Save();
        }
    }
}
