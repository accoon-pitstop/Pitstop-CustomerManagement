using Accoon.Pitshop.CustomerApi.Application.Interfaces.Database;
using Accoon.Pitshop.CustomerApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accoon.Pitshop.CustomerApi.Persistence.DatabaseContext
{
    public class CustomerDatabaseContext : DbContext, IDatabaseContext
    {
        // constructor
        public CustomerDatabaseContext(DbContextOptions<CustomerDatabaseContext> options) : base(options)
        {

        }

        // database entities
        public DbSet<Customer> Customers { get; set; }

        // register entity configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerDatabaseContext).Assembly);
        }



    }
}

// Add migrations
// Add-Migration InitMigration -Project Accoon.Pitshop.CustomerApi.Persistence -StartupProject Accoon.Pitshop.CustomerApi.Presenter -Context CustomerDatabaseContext
// update-database -Project Accoon.Pitshop.CustomerApi.Persistence -StartupProject Accoon.Pitshop.CustomerApi.Presenter