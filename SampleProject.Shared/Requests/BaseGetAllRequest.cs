namespace SampleProject.Shared.Requests
{
    public class BaseGetAllRequest
    {
        public int? PageSize { get; set; }
        public int PageIndex { get; set; }
        public string Filter { get; set; }
        public string SortField { get; set; }
        public bool? Asc { get; set; }
    }
}
