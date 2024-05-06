using MediatR;
using Sqrs.Commads.CreatStore.CQRS.Commands.CreateStore;
using Sqrs.Queries.GetStoreById;

namespace Sqrs.Commads.CreatStore
{

    public class CreateStoreCommandHandler(IStoreRepository storeRepository) : IRequestHandler<CreateStoreCommand, Unit>
    {
        private readonly IStoreRepository _storeRepository = storeRepository;


        public async Task<Unit> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            var store = new Store
            {
                Name = request.name,
            };

            await _storeRepository.Add(store);
            return Unit.Value;
        }

      
    }
}
