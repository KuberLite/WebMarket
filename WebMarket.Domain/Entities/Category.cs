using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebMarket.Domain.Entities
{
    public class Category
    {
        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

         public ICollection<Product> Products { get; set; }
    }
}
