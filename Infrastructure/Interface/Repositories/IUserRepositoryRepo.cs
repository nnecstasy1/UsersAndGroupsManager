namespace Infrastructure
{
    //Only extend for functionality specific to managing a User
    public interface IUserRepositoryRepo : IReadOnlyRepository<UserEntity>
    {

    }
}
