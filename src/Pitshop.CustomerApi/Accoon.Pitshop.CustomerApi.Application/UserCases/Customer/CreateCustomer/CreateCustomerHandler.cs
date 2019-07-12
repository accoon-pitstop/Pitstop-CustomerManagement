using Accoon.Pitshop.CustomerApi.Application.Interfaces.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Accoon.Pitshop.CustomerApi.Domain.Entities;

namespace Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.CreateCustomer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CustomerCreated>
    {
        private readonly IMediator mediator;
        private readonly IDatabaseContext databaseContext;

        public CreateCustomerHandler(IMediator mediator, IDatabaseContext context)
        {
            this.mediator = mediator;
            this.databaseContext = context;
        }

        public async Task<CustomerCreated> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = new Accoon.Pitshop.CustomerApi.Domain.Entities.Customer()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Address = request.Address,
                City = request.City,
                EmailAddress = request.EmailAddress,
                PostalCode = request.PostalCode,
                TelephoneNumber = request.TelephoneNumber

            };
            var a = this.databaseContext.Customers;

            //insert customer to database
            this.databaseContext.Customers.Add(entity);

            await this.databaseContext.SaveChangesAsync(cancellationToken);

            var newcustomer = new CustomerCreated { CustomerId = entity.Id };
            await this.mediator.Publish(newcustomer, cancellationToken);

            return newcustomer;
        }
    }
}
