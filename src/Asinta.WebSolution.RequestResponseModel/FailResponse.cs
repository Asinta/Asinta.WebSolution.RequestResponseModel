using System;

namespace Asinta.WebSolution.RequestResponseModel
{
    public class FailResponse : ResponseBase
    {
        public Exception Exception { get; set; }

        public FailResponse(int responseCode, string message, Exception ex = null)
        {
            ResponseCode = responseCode;
            Message = message;
            Exception = ex;
        }
    }

    public class FailResponse<T> : ResponseBase<T>
    {
        
        public Exception Exception { get; set; }

        public FailResponse(int responseCode, string message, Exception ex = null)
        {
            ResponseCode = responseCode;
            Message = message;
            Exception = ex;
        }
    }
}