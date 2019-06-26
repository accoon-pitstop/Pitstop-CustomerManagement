using Accoon.Pitshop.CustomerApi.Application.Interfaces.Automapper;
using AutoMapper;
using System;

namespace Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.GetCustomerList
{
    public class CustomerDetailModel : IHaveCustomMapping
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Accoon.Pitshop.CustomerApi.Domain.Entities.Customer, CustomerDetailModel>()
               .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.Id))
               .ForMember(cDTO => cDTO.Name, opt => opt.MapFrom(c => c.Name))
               .ForMember(cDTO => cDTO.Address, opt => opt.MapFrom(c => c.Address))
               .ForMember(cDTO => cDTO.City, opt => opt.MapFrom(c => c.City))
               .ForMember(cDTO => cDTO.PostalCode, opt => opt.MapFrom(c => c.PostalCode))
               .ForMember(cDTO => cDTO.TelephoneNumber, opt => opt.MapFrom(c => c.TelephoneNumber))
               .ForMember(cDTO => cDTO.EmailAddress, opt => opt.MapFrom(c => c.EmailAddress));
        }
    }
}