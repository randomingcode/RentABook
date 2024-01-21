using RentABook.Data;
using RentABook.Interfaces;
using RentABook.Models;

namespace RentABook.Repository
{
    public class PriceRepository : IPriceRepository
    {
        private readonly ApplicationDbContext _context;
        public PriceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Delete(Price price)
        {
            
            return Save();
        }

        public Task<IEnumerable<Price>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Price>> GetAllBooksByMaxPrice(double maxPrice)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Price>> GetAllBooksByMinPrice(double minPrice)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Price>> GetAllBooksByPriceRange(double minPrice, double maxPrice)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            
           var saved = _context.SaveChanges();
            
            return true;
            
            
        }

        public bool UpdatePrice(Price price)
        {
            return true;
        }
    }
}
