using System.ComponentModel.DataAnnotations;

namespace WebMarket.Domain.Entities.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
