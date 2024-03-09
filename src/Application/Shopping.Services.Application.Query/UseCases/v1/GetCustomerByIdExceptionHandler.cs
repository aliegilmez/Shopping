using Atlas.Framework.CleanArchitecture.Handling.Exception;

namespace Shopping.Services.Application.Query.UseCases.v1
{
    public class GetCustomerByIdExceptionHandler : ExceptionHandler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        public override async Task<HandlerState<GetCustomerByIdResponse>> HandleAsync(GetCustomerByIdRequest request, Exception exception, CancellationToken cancellationToken)
        {
            return FireException();
        }
    }
}
