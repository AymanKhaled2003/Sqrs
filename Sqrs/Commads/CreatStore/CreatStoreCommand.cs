using MediatR;

namespace Sqrs.Commads.CreatStore
{
    namespace CQRS.Commands.CreateStore
    {
        public record CreateStoreCommand(string name) : IRequest<Unit>;

        public interface IRequest
        {
        }
    }
}
