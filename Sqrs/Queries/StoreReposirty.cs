using Sqrs.Commads.CreatStore;
using Sqrs.Queries.GetStoreById;

namespace Sqrs.Queries
{
    public class StoreReposirty : IStoreRepository
    {
        public Task Add(Store store)
        {
            throw new NotImplementedException();
        }

        public Task<Store> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
