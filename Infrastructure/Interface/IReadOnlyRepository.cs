namespace Infrastructure
{
    public interface IReadOnlyRepository<T> where T : TEntity
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
