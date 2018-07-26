using Microsoft.EntityFrameworkCore;
using WebMarket.Domain.Entities;

namespace WebMarket.Domain.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasKey(b => b.CommentId);
        }

        DbSet<Category> Categories { get; set; }

        DbSet<Comment> Comments { get; set; }

        DbSet<Product> Products { get; set; } 
    }
}
