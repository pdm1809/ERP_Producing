namespace SampleProject.Shared.Responses
{
    public interface IResultActionResponse<T>
    {
        T Data { get; set; }
    }

    public class ActionResponse
    {
        public bool IsSucceeded { get; set; }
    }

    public class ActionResponse<T> : ActionResponse, IResultActionResponse<T>
    {
        public T Data { get; set; }
    }
}
