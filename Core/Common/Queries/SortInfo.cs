
namespace Core.Common.Queries
{
    public sealed class SortInfo
    {
        public string Column { get; set; }
        public bool Asc { get; set; }
        public bool Desc => !Asc;
    }
}
