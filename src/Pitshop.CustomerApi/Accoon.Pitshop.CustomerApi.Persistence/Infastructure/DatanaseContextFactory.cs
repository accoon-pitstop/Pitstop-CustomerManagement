using Accoon.Pitshop.CustomerApi.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Persistence.Infastructure
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<CustomerDatabaseContext>
    {
        public DatabaseContextFactory()
        {
            Debugger.Launch();
        }

        public CustomerDatabaseContext CreateDbContext(string[] args)
        {
            var currentDirentory = Path.Combine(Directory.GetCurrentDirectory());
            Console.WriteLine(currentDirentory);
            var resolver = new DependencyResolver
            {
                CurrentDirectory = currentDirentory

            };

            return resolver.ServiceProvider.GetService(typeof(CustomerDatabaseContext)) as CustomerDatabaseContext;
        }
    }
}
