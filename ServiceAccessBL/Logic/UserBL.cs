namespace ServiceAccessBL
{
    public class UserBL
    {
        readonly IHttpClientService _httpClientService;

        public UserBL(IServiceProvider serviceProvider)
        {
            _httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();
        }

        public UserBL(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<List<User>> GetUsers()
        {
            IAPICallResult<List<User>> result = await _httpClientService
                 .MakeRequest<List<User>>(HttpMethod.Get, "https://localhost:7288/api/user/", null)
                 .ConfigureAwait(true);

            if(!result.IsSuccessStatusCode)
            {
                return new List<User>();
            }

            return result.ResultObject;
        }
    }
}
