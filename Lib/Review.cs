using System;
using System.Collections.Generic;
namespace Lib
{
    public enum ReviewScore{
        Excellent,
        Positive,
        Neutral,
        OkIsh,
        Negative
    }

     public enum ReviewPriceRange{
        Expansive,
        NotCheap,
        Moderate,
        Affordable,
        Cheap
    }
    public class Review
    {
        public Review(DateTime Time)
        {
            this.Time=Time;
        }

        public ReviewScore ReviewScore {get; set;}
        public ReviewPriceRange ReviewPriceRange {get; set;}
        public DateTime Time {get; set;}

        public override string ToString()
        {
            return $"Review Score: {this.ReviewScore} \nReview was written on: {this.Time} \nPrices are: {this.ReviewPriceRange}";
        }
    }
}