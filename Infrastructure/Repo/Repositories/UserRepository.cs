namespace Infrastructure
{
    /// <summary>
    /// Users repository
    /// </summary>
    public class UserRepository : ReadOnlyRepository<UserEntity>, IUserRepositoryRepo
    {
        public UserRepository(InMemoryDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
