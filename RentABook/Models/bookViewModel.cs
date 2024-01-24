namespace RentABook.Models
{
    public class bookViewModel
    {
        public string Title { get; set; }

        public string? Author { get; set; }

        public string? Country { get; set; }

        public string? Language { get; set; }

        public int? Page {  get; set; }

        public int? Year { get; set; }

        public IFormFile Resim { get; set; }

        public Price Price { get; set; }


    }
}
