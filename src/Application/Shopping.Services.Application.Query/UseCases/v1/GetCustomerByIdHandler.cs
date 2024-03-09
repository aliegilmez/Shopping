using Atlas.Framework.CleanArchitecture.Handling;
using Atlas.Framework.Core.Exception;
using Shopping.Services.Application.Abstractions.Repositories;
using Shopping.Services.Data.Entities.MySql;
using Shopping.Services.Library.Common.MessageCodes;

namespace Shopping.Services.Application.Query.UseCases.v1
{
    public class GetCustomerByIdHandler : RequestHandler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerByIdHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public override async Task<GetCustomerByIdResponse> HandleAsync(GetCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.Id);

            if (customer is null)
                Throw.NotFoundException.With(m => m.Code(CommonCodes.DbEntityIsNotFound).Parameters(nameof(Customer), request.Id));

            return new GetCustomerByIdResponse
            {
                Id = request.Id,
                FirstName = customer!.FirstName,
                LastName = customer!.LastName,
                Email = customer!.Email,
                CreatedAt = customer.CreatedAt
            };
        }
    }
}
