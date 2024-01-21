using RentABook.Models;

namespace RentABook.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();

        Task<Book> GetByIdAsync(int id);

        Task<IEnumerable<Book>> GetAllBooksByAuthor(string author);

        bool Add(Book book);

        bool Update(Book book);

        bool Delete(Book book);

        bool Save();
    }
}
