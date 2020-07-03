using System;

namespace Asinta.WebSolution.RequestResponseModel
{
    public class RequestBase
    {
        public string RequestId { get; set; }

        public DateTimeOffset RequestTimestamp { get; set; }
    }

    public class RequestBase<T> : RequestBase
    {
        public T Content { get; set; }

        public RequestBase(T content = default(T))
        {
            Content = content;
        }
    }
}