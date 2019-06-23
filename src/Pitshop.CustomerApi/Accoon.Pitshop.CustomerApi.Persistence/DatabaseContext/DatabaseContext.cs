using Accoon.Pitshop.CustomerApi.Application.Interfaces.Database;
using Accoon.Pitshop.CustomerApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accoon.Pitshop.CustomerApi.Persistence.DatabaseContext
{
    public class DefaultDatabaseContext : DbContext, IDatabaseContext
    {
        // constructor
        public DefaultDatabaseContext(DbContextOptions<DefaultDatabaseContext> options) : base(options)
        {

        }

        // database entities
        public DbSet<Customer> Customers { get; set; }

        // register entity configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DefaultDatabaseContext).Assembly);
        }



    }
}

// Add migrations
// Add-Migration InitMigration -Project Accoon.Pitshop.CustomerApi.Persistence -StartupProject Accoon.Api -Context DefaultDatabaseContext
// update-database -Project Accoon.Pitshop.CustomerApi.Persistence -StartupProject Accoon.Api