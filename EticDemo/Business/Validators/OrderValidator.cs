using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class OrderValidator:AbstractValidator<Order>, IOrderValidator
    {
        public OrderValidator()
        {
            RuleFor(o => o.Name).NotNull().NotEmpty().MaximumLength(3).WithMessage("Name length can be minimum 3");
            RuleFor(o => o.Surname).NotNull().NotEmpty().MaximumLength(3).WithMessage("Surname length can be minimum 3");
            RuleFor(o => o.Address).NotNull().NotEmpty().WithMessage("Addres can not be empty");
            RuleFor(o => o.Email).NotNull().NotEmpty().EmailAddress().WithMessage("Please enter a valid email address");
            RuleFor(o => o.PhoneNumber).NotNull().NotEmpty().WithMessage("Phone number can not be empty");
        }
    }
}
