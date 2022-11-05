namespace Infrastructure
{
    /// <summary>
    /// Unit Of Work, handle multiple entities on a single connection.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InMemoryDbContext _context;
        private bool disposed;

        public UnitOfWork(InMemoryDbContext context) => _context = context;
        
        #region Repositories
        public IUserRepositoryRepo UserRepository
        {
            get => new UserRepository(_context);
        }

        public IClientGroupRepo ClientGroupRepository
        {
            get => new ClientGroupRepository(_context);
        }

        public IClientGroupUserRepo ClientGroupUserRepository
        {
            get => new ClientGroupUserRepository(_context);
        }
        #endregion
        public async Task SaveChanges() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            if(!disposed)
            {
                if(dispose) _context.Dispose();
                disposed = true;
            }
        }
    }
}
