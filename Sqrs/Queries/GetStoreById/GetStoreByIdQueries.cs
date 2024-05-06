using MediatR;
using System.Xml;

namespace Sqrs.Queries.GetStoreById
{
    

    public record GetStoreByIdQuery(long Id) : IRequest<StoreResponse>;     
}
