using Atlas.Framework.CleanArchitecture.Handling.Contract;

namespace Shopping.Services.Application.Query.UseCases.v1
{
    public class GetCustomerByIdRequest : IRequest<GetCustomerByIdResponse>
    {
        public int Id { get; set; }
    }
}
