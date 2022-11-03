namespace ServiceAccessBL
{
    public class HttpClientService : IHttpClientService
    {
        private readonly IHttpClientFactory clientFactory;
        public HttpClientService(IHttpClientFactory httpClientFactory)
        {
            clientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public async Task<APICallResult<T>> MakeRequest<T>(HttpMethod method, string endPoint, string? requestContent = null)
        {
            var request = new HttpRequestMessage(method, endPoint);

            if (requestContent != null)
                request.Content = new StringContent(requestContent, Encoding.UTF8, "application/json");

            try
            {
                using var client = this.clientFactory.CreateClient();

                HttpResponseMessage httpResponseMessage = await client.SendAsync(request, CancellationToken.None)
                    .ConfigureAwait(true);

                APICallResult<T> apiCallResult = new APICallResult<T>
                {
                    IsSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode,
                    HttpStatusCode = httpResponseMessage.StatusCode,
                };

                string apiResponse = await GetAPIResponse(httpResponseMessage).ConfigureAwait(true);
                if (!string.IsNullOrEmpty(apiResponse))
                {
                    apiCallResult.ResultObject = JsonConvert.DeserializeObject<T>(apiResponse);
                }

                return apiCallResult;
            }
            catch
            {
                //log exception and throw a proper message.
                throw;
            }
        }

        private async Task<string> GetAPIResponse(HttpResponseMessage httpResponseMessage)
        {
            string result = string.Empty;

            if (httpResponseMessage.IsSuccessStatusCode
                && httpResponseMessage.Content != null
                && httpResponseMessage.Content.Headers != null
                && httpResponseMessage.Content.Headers.ContentLength > 0)
            {
                result = await ReadAsStringAsync(httpResponseMessage).ConfigureAwait(true);
            }

            return result;
        }

        private async Task<string> ReadAsStringAsync(HttpResponseMessage responseMessage)
        {
            if (responseMessage == null)
            {
                throw new ArgumentNullException(nameof(responseMessage));
            }

            return await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(true);
        }
    }
}
