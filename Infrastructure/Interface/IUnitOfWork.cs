namespace Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        #region "Repositories"
        IUserRepositoryRepo UserRepository { get; }
        IClientGroupRepo ClientGroup { get; }
        IClientGroupUserRepo ClientGroupUser { get; }
        #endregion
        Task SaveChanges();
    }
}
