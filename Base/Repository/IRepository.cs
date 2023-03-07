namespace Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        bool Delete(T entity);
        T? GetById(int id);
        IEnumerable<T> GetAll();
    }
}
