namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGenericService<T> where T : class, new()
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetList();
    }
}
