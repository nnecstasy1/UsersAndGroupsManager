namespace ServiceAccessBL
{
    public class APICallResult<T> : IAPICallResult<T>
    {
            public bool IsSuccessStatusCode { get; set; }
            public HttpStatusCode HttpStatusCode { get; set; }
            public List<string> LocationSegments { get; set; }
            public T ResultObject { get; set; }
            public string Message { get; set; }
    }
}
