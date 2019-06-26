﻿using Accoon.Pitshop.CustomerApi.Application.Interfaces.Automapper;
using AutoMapper;
using System;

namespace Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.GetCustomerList
{
    public class CustomerDetailModel : IHaveCustomMapping
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Accoon.Pitshop.CustomerApi.Domain.Entities.Customer, CustomerDetailModel>()
               .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.Id))
               .ForMember(cDTO => cDTO.Name, opt => opt.MapFrom(c => c.Name));
        }
    }
}