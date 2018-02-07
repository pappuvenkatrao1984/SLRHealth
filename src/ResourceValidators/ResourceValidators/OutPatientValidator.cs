using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ResourceModel;

namespace ResourceValidators
{
    public class OutPatientValidator : AbstractValidator<OutPatient>
    {
        public OutPatientValidator()
        {
            RuleFor(x => x.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Matches(@"[A-Z]")
                .WithMessage("Invalid First Name");
            RuleFor(x => x.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Matches(@"[A-Z]")
                .WithMessage("Invalid First Name");
            RuleFor(x => x.Addr1)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("Invalid First Name");
            RuleFor(x => x.City)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Matches(@"[A-Z]")
                .WithMessage("Invalid First Name");
            RuleFor(x => x.State)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Matches(@"[A-Z]")
                .WithMessage("Invalid First Name");
            RuleFor(x => x.Country)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Matches(@"[A-Z]")
                .WithMessage("Invalid First Name");
            RuleFor(x => x.ZipCode.ToString())
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()     
                .Matches(@"[0-9]")
               .WithMessage("Invalid Zip Code");
        }
    }
}
