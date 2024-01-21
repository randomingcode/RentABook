using RentABook.Models;

namespace RentABook.Interfaces
{
    public interface IPriceRepository
    {
        Task<IEnumerable<Price>> GetAll();
        Task<IEnumerable<Price>> GetAllBooksByMinPrice (double minPrice);
        Task<IEnumerable<Price>> GetAllBooksByMaxPrice(double maxPrice);
        Task<IEnumerable<Price>> GetAllBooksByPriceRange(double minPrice, double maxPrice);

        bool UpdatePrice(Price price);

        bool Delete(Price price);

        bool Save();
    }
}
