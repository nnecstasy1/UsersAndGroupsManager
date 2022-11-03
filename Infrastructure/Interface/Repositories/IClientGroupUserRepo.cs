namespace Infrastructure
{
    public interface IClientGroupUserRepo : IRepository<ClientGroupUserEntity>
    {
        Task<IEnumerable<ClientGroupUserEntity>> GetUserAssignedClientGroupsByUserId(int userId);
        Task<IEnumerable<ClientGroupUserEntity>> GetUsersAssignedToClientGroupByClientGroupId(int clientGroupId);
    }
}
