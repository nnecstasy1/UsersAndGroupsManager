namespace ServiceAccessBL
{
    public class UserGroupsBL
    {
        readonly IHttpClientService _httpClientService;
        private readonly ClientGroupBL _clientGroupBL;

        public UserGroupsBL(IServiceProvider serviceProvider)
        {
            _httpClientService = serviceProvider.GetRequiredService<IHttpClientService>();
            _clientGroupBL = new ClientGroupBL(serviceProvider);
        }

        public Tuple<List<UserGroups>, List<UserGroups>> GetAssignedUsersGroupsAsync(int userId)
        {
            List<int> assignedClientGroupsForUser = _clientGroupBL.GetClientGroupsForUser(userId);

            List<UserGroups> assignedGroups = new List<UserGroups>();
            List<UserGroups> unassignedGroups = new List<UserGroups>();

            List<UserGroups> userGroupsTask = Task.Run(() => GetUserGroups()).Result;

            assignedGroups.AddRange(userGroupsTask.Where(x => x.Id.In(assignedClientGroupsForUser.ToArray())));
            unassignedGroups.AddRange(userGroupsTask.Where(x => !x.Id.In(assignedClientGroupsForUser.ToArray())));

            return new Tuple<List<UserGroups>, List<UserGroups>>(assignedGroups, unassignedGroups);
        }

        //TODO: update endpoint, parameterize url
        private async Task<List<UserGroups>> GetUserGroups()
        {
            IAPICallResult<List<UserGroups>> result = await _httpClientService
                 .MakeRequest<List<UserGroups>>(HttpMethod.Get, "https://localhost:7288/api/clientgroup/", null)
                 .ConfigureAwait(true);

            if (!result.IsSuccessStatusCode)
            {
                return new List<UserGroups>();
            }

            return result.ResultObject;
        }
    }
}
