namespace ServiceAccessBL
{
    public class ClientGroupBL
    {
        readonly IHttpClientService _httpClientService;
        private const string controller = "clientgroupuser";

        public ClientGroupBL(IServiceProvider serviceProvider)
        {
            _httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();
        }

        public List<int> GetClientGroupsForUser(int id)
        {
            List<int> groups = new List<int>();
            List<ClientGroups> clientGroupItems = Task.Run(() => GetClientGroupsForUserAPI(id)).Result;

            foreach (var item in clientGroupItems)
            {
                groups.Add(item.ClientGroupId);
            }
            return groups;
        }
        
        public async Task AssignUserOrUnAssignToGroup(bool assignment, int userId, List<UserGroups> userGroups)
        {
            List<ClientGroups> clientGroups = new List<ClientGroups>();

            foreach (var ug in userGroups)
            {
                clientGroups.Add(new ClientGroups()
                {
                    UserId = userId,
                    ClientGroupId = ug.Id
                });
            }

            if (clientGroups.Any())
            {
                await AssignOrUnAssignUsersToGroupAPI(JsonConvert.SerializeObject(clientGroups), assignment);
            }
        }

        //TODO: update endpoint, parameterize url
        private async Task<List<ClientGroups>> GetClientGroupsForUserAPI(int id)
        {
            IAPICallResult<List<ClientGroups>> result = await _httpClientService
                 .MakeRequest<List<ClientGroups>>(HttpMethod.Get, $"https://localhost:7288/api/{controller}/usergroups/{id}/", null)
                 .ConfigureAwait(true);

            if (!result.IsSuccessStatusCode)
            {
                return new List<ClientGroups>();
            }

            return result.ResultObject;
        }

        private async Task AssignOrUnAssignUsersToGroupAPI(string body, bool assign = false)
        {
            string method = "deletemany";
            HttpMethod httpMethod = HttpMethod.Delete;
            if(assign)
            {
                method = "addmany";
                httpMethod = HttpMethod.Put;
            }

            IAPICallResult<List<UserGroups>> result = await _httpClientService
                 .MakeRequest<List<UserGroups>>(httpMethod, $"https://localhost:7288/api/{controller}/{method}", body)
                 .ConfigureAwait(true);
        }
    }
}
