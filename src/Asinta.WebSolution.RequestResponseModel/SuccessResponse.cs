namespace Asinta.WebSolution.RequestResponseModel
{
    public class SuccessResponse : ResponseBase
    {
        public SuccessResponse()
        {
            IsSuccess = true;
        }
    }

    public class SuccessResponse<T> : ResponseBase<T>
    {
        public SuccessResponse(T content = default(T)): base(content)
        {
            IsSuccess = true;
        }
    }
}