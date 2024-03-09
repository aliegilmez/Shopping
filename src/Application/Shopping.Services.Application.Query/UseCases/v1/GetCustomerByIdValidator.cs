using Atlas.Framework.CleanArchitecture.Handling.Validation;
using FluentValidation;
using Shopping.Services.Library.Common.MessageCodes;

namespace Shopping.Services.Application.Query.UseCases.v1
{
    public class GetCustomerByIdValidator : RequestValidator<GetCustomerByIdRequest>
    {
        public GetCustomerByIdValidator()
        {
            RuleFor(m => m).NotNull().WithErrorCode(ValidationCodes.RequestCouldNotBeNull);
        }
    }
}
