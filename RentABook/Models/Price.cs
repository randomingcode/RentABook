namespace RentABook.Models
{
    public class Price
    {
        public Price()
        {
            if(DiscountRatio > 0)
            {
                DiscountedPrice = OriginalPrice * DiscountRatio;
            }
              
        }
        public int Id { get; set; }

        public double OriginalPrice { get; set; }

        public double DiscountRatio { get; set; }

        public double DiscountedPrice { get;set; }

        public Book Book { get; set; }

        public string? BookName { get; set; }



    }
}