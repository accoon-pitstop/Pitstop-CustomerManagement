using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accoon.Pitshop.CustomerApi.Application.UserCases.Customer.CreateCustomer
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required");

            RuleFor(x => x.EmailAddress)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Not a valid Email Address")
                .MaximumLength(255);

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address is required")
                .MaximumLength(1000);

            RuleFor(x => x.TelephoneNumber)
               .NotEmpty().WithMessage("Telephone number is required");
               //.Matches(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}");

        }
    }
}
