using System;
using System.Collections.Generic;
using System.Text;

namespace WebMarket.Domain.Entities
{
    public class Rating
    {
        public string RatingId { get; set; }

        public string UserId { get; set; }

        public double RatingValue { get; set; }
    }
}
