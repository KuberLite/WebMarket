using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace WebMarket.Domain.EF
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        private IConfiguration configuration = ConfigurationFactory.BuildConfiguration();

        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ApplicationContext"), b => b.MigrationsAssembly("WebMarket.Domain"));

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
