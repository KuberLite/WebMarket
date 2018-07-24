using System.ComponentModel.DataAnnotations;

namespace WebMarket.Domain.Entities
{
    public class Products
    {
        [Key]
        public string ProductId { get; set; }

        public string CategoryId { get; set; }

        public string DescriptionProduct { get; set; }

        public int Price { get; set; }

        public int Rating { get; set; }
    }
}
