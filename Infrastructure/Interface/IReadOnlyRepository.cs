namespace Infrastructure
{
    public interface IReadOnlyRepository<T> where T : TEntity
    {
        Task<T> GetSingle(int id);
        Task<IEnumerable<T>> GetMany();
    }
}
