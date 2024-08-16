using SampleProject.Shared.Constants;

namespace SampleProject.Shared.Responses
{
    public class FailActionResponse : ActionResponse
    {
        public string ErrorMessage { get; set; }
        public ErrorCode ErrorCode { get; set; }
        public int? SubErrorCode { get; set; }
        public string ErrorCodeString => ErrorCode.ToString();
        public string SubErrorCodeString { get; set; }
    }

    public class FailActionResponse<T> : FailActionResponse, IResultActionResponse<T>
    {
        public T Data { get; set; }
    }
}
