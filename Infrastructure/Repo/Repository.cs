namespace Infrastructure
{
    /// <summary>
    /// Generic Repository
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public class Repository<T> : ReadOnlyRepository<T>, IRepository<T> where T : TEntity
    {
        private readonly InMemoryDbContext _context;
        public Repository(InMemoryDbContext dbContext)
            :base(dbContext) => _context = dbContext;

        public async void Add(T entity)
        {
            await _context.AddAsync(entity);
        }

        public async void Add(T[] entity)
        {
            await _context.AddRangeAsync(entity);
        }

        public void Delete(int Id)
        {
            try
            {
                T entity = Task.Run(() => Get(Id)).Result;
                if(entity != null)
                    _context.Set<T>().Remove(entity);
            }
            catch
            {
                throw;
            }
        }

        public void Delete(T[] entity)
        {
            try
            {
                if (entity != null)
                    _context.RemoveRange(entity);
            }
            catch
            {
                throw;
            }
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
