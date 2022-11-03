namespace Infrastructure
{
    //only extend for functionality specific to managing user groups
    public interface IClientGroupRepo : IReadOnlyRepository<ClientGroupEntity>
    {
    }
}
