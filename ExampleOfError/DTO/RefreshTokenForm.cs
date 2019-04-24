using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleOfError.Validation;
using FluentValidation;

namespace ExampleOfError.DTO
{
    public class RefreshTokenForm
    {

        public string Token { get; set; }
    }

    public class RefreshTokenFormValidation : AbstractValidator<RefreshTokenForm>
    {
        public RefreshTokenFormValidation()
        {
            RuleFor(x => x.Token).NotNull().NotEmpty().MustBeRefreshToken();
        }


    }
}
