namespace ServiceAccessBL
{
    public class ClientGroupBL
    {
        readonly IHttpClientService _httpClientService;

        public ClientGroupBL(IServiceProvider serviceProvider)
        {
            _httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();
        }

        public List<int> GetClientGroupsForUser(int id)
        {
            List<int> groups = new List<int>();
            List<ClientGroups> clientGroupItems = Task.Run(()=>GetClientGroupsForUserAPI(id)).Result;

            foreach (var item in clientGroupItems)
            {
                groups.Add(item.ClientGroupId);
            }
            return groups;
        }

        //TODO: update endpoint, parameterize url
        private async Task<List<ClientGroups>> GetClientGroupsForUserAPI(int id)
        {
            IAPICallResult<List<ClientGroups>> result = await _httpClientService
                 .MakeRequest<List<ClientGroups>>(HttpMethod.Get, $"https://localhost:7288/api/clientgroupuser/usergroups/{id}/", null)
                 .ConfigureAwait(true);

            if (!result.IsSuccessStatusCode)
            {
                return new List<ClientGroups>();
            }

            return result.ResultObject;
        }
    }
}
