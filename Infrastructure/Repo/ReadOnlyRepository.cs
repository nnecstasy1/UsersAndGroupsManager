namespace Infrastructure
{
    /// <summary>
    /// ReadOnly Repository
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public class ReadOnlyRepository<T> : IReadOnlyRepository<T> where T : TEntity
    {
        private readonly InMemoryDbContext _context;
        public ReadOnlyRepository(InMemoryDbContext context) => _context = context;
        public async Task<T> Get(int id) => await _context.Set<T>().FindAsync(id);
        public async Task<IEnumerable<T>> GetAll()
        {
            var result = await Task.Run(() => _context.Set<T>());
            return result;
        }
    }
}
