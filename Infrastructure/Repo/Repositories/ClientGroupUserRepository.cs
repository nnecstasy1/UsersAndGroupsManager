namespace Infrastructure
{
    /// <summary>
    /// Client Groups and User mapping repository
    /// </summary>
    public class ClientGroupUserRepository : Repository<ClientGroupUserEntity>, IClientGroupUserRepo
    {
        public ClientGroupUserRepository(InMemoryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<ClientGroupUserEntity>> GetUserAssignedClientGroupsByUserId(int userId)
        {
            IEnumerable<ClientGroupUserEntity> usersGroups = await Task.Run(() => GetMany().Result.Where(x => x.UserId == userId));
            return usersGroups;
        }

        public async Task<IEnumerable<ClientGroupUserEntity>> GetUsersAssignedToClientGroupByClientGroupId(int clientGroupId)
        {
            IEnumerable<ClientGroupUserEntity> usersGroups = await Task.Run(() => GetMany().Result.Where(x => x.ClientGroupId == clientGroupId));
            return usersGroups;
        }
    }
}
