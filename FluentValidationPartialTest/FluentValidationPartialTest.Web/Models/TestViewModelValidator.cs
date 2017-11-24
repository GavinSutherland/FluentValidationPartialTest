using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationPartialTest.Web.Models
{
    public class TestViewModelValidator : AbstractValidator<TestViewModel>
    {
        public TestViewModelValidator()
        {
            RuleFor(vm => vm.DateOfBirth)
                .NotEmpty()
                .WithMessage("THIS IS NEEDED");

            RuleFor(vm => vm.AnotherDate)
                .NotEmpty()
                .WithMessage("THIS IS ALSO NEEDED");
        }
    }
}
