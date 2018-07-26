using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.Domain.Entities
{
    public class Product
    {
        public string ProductId { get; set; }

        public string CategoryId { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public string RatingId { get; set; }

        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
