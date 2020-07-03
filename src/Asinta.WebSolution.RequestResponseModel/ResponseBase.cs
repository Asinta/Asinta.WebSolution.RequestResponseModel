namespace Asinta.WebSolution.RequestResponseModel
{
    public class ResponseBase
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public dynamic Additional { get; set; }

        public int ResponseCode { get; set; }

        public ResponseBase(): this(false) {}
        
        public ResponseBase(bool isSuccess = false, string message = "")
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }

    public class ResponseBase<T> : ResponseBase
    {
        public T Content { get; set; }
        
        public ResponseBase(): this(default) {}

        public ResponseBase(T content = default)
        {
            Content = content;
        }
    }
}