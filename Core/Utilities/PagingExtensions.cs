
namespace Core.Utilities
{
    public static class PagingExtensions
    {
        public static IQueryable<TSource> Page<TSource>(this IQueryable<TSource> source, int pageIndex, int pageSize)
        {
            if (pageIndex < 0)
                pageIndex = 0;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;
            return source.Skip(pageIndex * pageSize).Take(pageSize);
        }
    }
}
