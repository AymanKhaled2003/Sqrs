
using Sqrs.Commads.CreatStore;

namespace Sqrs.Queries.GetStoreById
{
    public interface IStoreRepository
    {
        Task<Store> GetByIdAsync(long id);
        Task Add(Store store);

    }
}