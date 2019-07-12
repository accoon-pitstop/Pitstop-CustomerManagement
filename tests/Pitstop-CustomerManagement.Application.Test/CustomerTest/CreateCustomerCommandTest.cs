using Accoon.Pitshop.CustomerApi.Application.Interfaces.Database;
using Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.CreateCustomer;
using Accoon.Pitshop.CustomerApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Pitstop_CustomerManagement.Application.Test.CustomerTest
{
    public class CreateCustomerCommandTest
    {
        [Fact]
        public async Task Handle_Customer_CreatedNitification()
        {
            // Arrage

            // get mock ef data set and database context
            var mockCustomerDataSet = new Mock<DbSet<Customer>>();
            var databaseInstance = new Mock<IDatabaseContext>();
            databaseInstance.Setup(x => x.Customers).Returns(mockCustomerDataSet.Object);

            // mock create customer command handler
            var mediatorMock = new Mock<IMediator>();
            var customerCreatedCommandHandler = new CreateCustomerHandler(mediatorMock.Object, databaseInstance.Object);
            var newCustomerId = Guid.NewGuid();

            // Act
            var result = await customerCreatedCommandHandler.Handle(new CreateCustomerCommand() { Name = "aaa" }, CancellationToken.None);
            result.CustomerId = newCustomerId;

            // Assert
            mediatorMock.Verify(m => m.Publish(It.Is<CustomerCreated>(cc => cc.CustomerId == newCustomerId), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
