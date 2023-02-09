using MediatR;

//need install MediatR package
namespace Core.Common.Queries
{
    public class ListQuery<T> : IRequest<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string GlobalFilter { get; set; }
        public List<SortInfo> SortBy => SorterValue == null || SorterValue.Column == null ? new List<SortInfo>() : new List<SortInfo> { SorterValue };
        public SortInfo SorterValue { get; set; }
        public List<FilterInfo> Filters { get; set; }
    }
}
