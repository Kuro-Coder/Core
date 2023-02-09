using MediatR;

namespace Core.Common.Queries
{
    public class SingleQuery<T> : IRequest<T>
    {
    }
}
