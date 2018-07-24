using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebMarket.Domain.Entities;

namespace WebMarket.Domain.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasKey(c => new { c.CommentId, c.ProductId, c.UserId });
        }

        DbSet<Category> Categories { get; set; }

        DbSet<Comment> Comments { get; set; }

        DbSet<Person> Persons { get; set; }

        DbSet<Products> Products { get; set; } 
    }
}
