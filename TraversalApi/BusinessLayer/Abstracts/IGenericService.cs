namespace TraversalApi.BusinessLayer.Abstracts
{
    //public interface IGenericService<T> where T : class, new()
    //{
    //void TInsert(T entity);
    //void TUpdate(T entity);
    //void TDelete(T entity);
    //T TGetById(int id);
    //List<T> TGetList();
    //}

    public interface IGenericService<TDto, TAddDto, TUpdateDto, TListDto>
    where TDto : class
    where TAddDto : class
    where TUpdateDto : class
    where TListDto : class
    {
        List<TListDto> TGetList();
        TDto TGetById(int id);
        void TInsert(TAddDto dto);
        void TUpdate(TUpdateDto dto);
        void TDelete(int id);
    }
}
