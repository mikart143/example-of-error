using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ExampleOfError.Validation
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilderInitial<T, string> MustBeRefreshToken<T>(this IRuleBuilder<T, string> ruleBuilder)
        {

            return ruleBuilder.Custom((token, contextPropertyValidatorContext) =>
            {


                var context = contextPropertyValidatorContext.GetServiceProvider();

                
            });
        }
    }
}
