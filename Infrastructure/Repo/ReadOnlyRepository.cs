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
        public async Task<T> GetSingle(int id) => await _context.Set<T>().FindAsync(id);
        public async Task<IEnumerable<T>> GetMany() => await Task.Run(() => _context.Set<T>());
    }
}
