using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RentABook.Models
{
    public class Price
    {
        public int Id { get; set; }

        public double OriginalPrice { get; set; }

        public double DiscountRatio { get; set; }

        public double DiscountedPrice { get; set; }

        public Book Book { get; set; }

        public string? BookName { get; set; }

        public Price()
        {
            Triggers<Price>.Inserted += equals =>
            {
                if (DiscountRatio>0) {
                    DiscountedPrice = OriginalPrice * DiscountRatio;
                }
                else
                {
                    DiscountedPrice = OriginalPrice * 1;
                }
                
            };
        }

    }
}