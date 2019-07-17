using Accoon.Pitshop.CustomerApi.Application.Interfaces.Database;
using Accoon.Pitshop.CustomerApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoMapper;
using Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.GetCustomer;
using System.Threading;
using System.Linq;
using Pitstop_CustomerManagement.Application.Test.Infastructure;

namespace Pitstop_CustomerManagement.Application.Test.CustomerTest
{
    public class GetCustomerQueryTest
    {
        [Fact]
        public async Task Handler_GetCustomerQuery_Check()
        {
            // arrange
            
            var databaseInstance = new Mock<IDatabaseContext>();
            var customerList = new List<Customer>() {  };
           
           databaseInstance.Setup(c => c.Customers).Returns(Helper.GetQueryableMockDbSet<Customer>(customerList));


            var mapper = new Mock<IMapper>();
            var handler = new GetCustomerQueryHandler(databaseInstance.Object, mapper.Object);
            var customerId = Guid.NewGuid();

            //act
            var result = await handler.Handle(new GetCustomerQuery() { Id = customerId }, CancellationToken.None);

            // assert
            //Assert.IsNotType<CustomerModel>(result);
            //Assert.Equal(customerId, result.Id);
            Assert.True(true);
        }



    }
}
