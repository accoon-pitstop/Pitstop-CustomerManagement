using Accoon.Pitshop.CustomerApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(250).IsRequired();
            builder.Property(e => e.EmailAddress).HasMaxLength(255).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(1000).IsRequired();
            builder.Property(e => e.TelephoneNumber).HasMaxLength(15).IsRequired();
        }
    }
}
