using System.ComponentModel.DataAnnotations.Schema;

namespace RentABook.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string? Country { get; set; }

        public string ImageLink { get; set; } = null!;

        public string? Language { get; set; }

        public int Page { get; set; } 

        public int Year { get; set; } 

        public string? Link { get; set; }

        public int PriceId { get; set; }
        public Price? Price { get; set; }

    }
}
