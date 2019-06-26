using Accoon.Pitshop.CustomerApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Domain.Entities
{
    public class Customer : Entity<Guid>
    {
        public Customer()
        {
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }

    }
}
