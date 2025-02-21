namespace TraversalApi.DataAccessLayer.Abstract
{
    public interface IGenericRepositoryDal<T> where T : class, new()
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetList();
        T GetById(int id);
    }
}
