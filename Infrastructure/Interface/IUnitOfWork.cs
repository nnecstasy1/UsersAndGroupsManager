namespace Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        #region "Repositories"
        IUserRepositoryRepo UserRepository { get; }
        IClientGroupRepo ClientGroupRepository { get; }
        IClientGroupUserRepo ClientGroupUserRepository { get; }
        #endregion
        Task SaveChanges();
    }
}
