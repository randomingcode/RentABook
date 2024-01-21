using Microsoft.EntityFrameworkCore;
using RentABook.Models;

namespace RentABook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Price> Prices { get; set; }
    }

}