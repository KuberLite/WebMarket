using System.ComponentModel.DataAnnotations;

namespace WebMarket.Domain.Entities
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
