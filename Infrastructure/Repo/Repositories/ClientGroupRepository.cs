namespace Infrastructure
{
    /// <summary>
    /// Client Groups repository
    /// </summary>
    public class ClientGroupRepository : ReadOnlyRepository<ClientGroupEntity>, IClientGroupRepo
    {
        public ClientGroupRepository(InMemoryDbContext context) : base(context)
        {
        }
    }
}
