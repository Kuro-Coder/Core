using System.Collections;

namespace Core.Common.Queries
{
    public interface IListQueryResult
    {
        long TotalCount { get; set; }
        IEnumerable GetItems();
    }

    public abstract class QueryResult : Result
    {
    }

    public class ListQueryResult<T> : QueryResult, IListQueryResult
    {
        public ICollection<T> Data { get; set; }

        public IEnumerable GetItems()
        {
            return Data;
        }

        public long TotalCount { get; set; } = -1;

    }

    public interface ISingleQueryResult
    {
    }

    public class SingleQueryResult<T> : QueryResult, ISingleQueryResult
    {
        public T Data { get; set; }
    }
}
