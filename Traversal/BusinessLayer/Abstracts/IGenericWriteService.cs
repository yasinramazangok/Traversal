namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGenericWriteService<TAddDto, TUpdateDto>
    where TAddDto : class
    where TUpdateDto : class
    {
        void TInsert(TAddDto dto);
        void TUpdate(TUpdateDto dto);
        void TDelete(int id);
    }
}
