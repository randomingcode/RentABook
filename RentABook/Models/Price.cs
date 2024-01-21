namespace RentABook.Models
{
    public class Price
    {
 
        public int Id { get; set; }

        public double OriginalPrice { get; set; }

        public float? DiscountRatio { get; set; }

        public double DiscountedPrice { get; set; }

        public Book Book { get; set; }

        public string? BookName { get; set; }



    }
}