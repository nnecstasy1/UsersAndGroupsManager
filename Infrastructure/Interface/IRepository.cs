namespace Infrastructure
{
    public interface IRepository<T> : IReadOnlyRepository<T> where T : TEntity
    {
        void Add(T entity);
        void Add(T[] entity);
        void Update(T entity);
        void Delete(int id);
        void Delete(T[] entity);
    }
}
