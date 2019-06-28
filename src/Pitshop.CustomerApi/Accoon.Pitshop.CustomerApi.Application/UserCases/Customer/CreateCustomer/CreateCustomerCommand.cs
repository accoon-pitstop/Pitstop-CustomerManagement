using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<CustomerCreated>
    {        
        public string  Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}

