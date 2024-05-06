using MediatR;
using Sqrs.Commads.CreatStore;

namespace Sqrs.Queries.GetStoreById
{

    public class GetStoreByIdQueryHandler : IRequestHandler<GetStoreByIdQuery, StoreResponse>
    {
        private readonly IStoreRepository _storeRepository;

        public GetStoreByIdQueryHandler(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task<StoreResponse> Handle(GetStoreByIdQuery request, CancellationToken cancellationToken)
        {
            var store = new StoreResponse
            {
                Id = (await _storeRepository.GetByIdAsync(request.Id)).Id,
                Name = (await _storeRepository.GetByIdAsync(request.Id)).Name
            };
            return store;
        }
    }
}
