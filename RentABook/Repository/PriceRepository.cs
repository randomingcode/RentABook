using Microsoft.EntityFrameworkCore;
using RentABook.Data;
using RentABook.Interfaces;
using RentABook.Models;

namespace RentABook.Repository
{
    public class PriceRepository : IPriceRepository
    {
        private ApplicationDbContext _context;
        public PriceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Delete(Price price)
        {

            _context.Remove(price);
            return Save();
        }

        public async Task<IEnumerable<Price>> GetAll()
        {
            return await _context.Prices.ToListAsync();
        }

        public async Task<IEnumerable<Price>> GetAllBooksByMaxPrice(double maxPrice)
        {
            return await _context.Prices.Where(a => a.DiscountedPrice <= maxPrice).ToListAsync();
        }

        public async Task<IEnumerable<Price>> GetAllBooksByMinPrice(double minPrice)
        {
            return await _context.Prices.Where(a => a.DiscountedPrice >= minPrice).ToListAsync();
        }

        public async Task<IEnumerable<Price>> GetAllBooksByPriceRange(double minPrice, double maxPrice)
        {
            return await _context.Prices.Where(a => (a.DiscountedPrice >= minPrice && a.DiscountedPrice <= maxPrice)).ToListAsync();
        }

        public bool Save()
        {

            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;


        }

        public bool UpdatePrice(Price price)
        {
            return true;
        }
    }
}
