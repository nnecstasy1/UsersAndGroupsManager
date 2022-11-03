namespace ServiceAccessBL
{
    public interface IHttpClientService
    {
        Task<APICallResult<T>> MakeRequest<T>(HttpMethod method, string endPoint, string? requestContent);
    }
}
