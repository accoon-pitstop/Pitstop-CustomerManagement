using Accoon.Pitshop.CustomerApi.Application.Interfaces.Automapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.GetCustomer
{
    public class CustomerModel : IMapFrom<Accoon.Pitshop.CustomerApi.Domain.Entities.Customer>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
