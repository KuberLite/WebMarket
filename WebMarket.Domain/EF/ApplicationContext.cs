using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebMarket.Domain.Entities.Models;

namespace WebMarket.Domain.EF
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base()
        {

        }

        DbSet<Category> Categories { get; set; }

        DbSet<Comments> Comments { get; set; }

        DbSet<Person> Persons { get; set; }

        DbSet<Products> Products { get; set; } 
    }
}
