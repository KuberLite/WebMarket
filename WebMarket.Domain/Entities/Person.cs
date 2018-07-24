using System;
using System.ComponentModel.DataAnnotations;

namespace WebMarket.Domain.Entities
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }

        public string NickName { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }
    }
}
