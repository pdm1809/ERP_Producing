using System;

namespace SampleProject.Shared.Requests
{
    public interface IDateTimeFilterGetAllRequest
    {
        DateTime? FromDate { get; set; }
        DateTime? ToDate { get; set; }
    }
}
