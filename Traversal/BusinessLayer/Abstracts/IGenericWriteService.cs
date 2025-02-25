namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGenericWriteService<TAddDto, TUpdateDto>
    where TAddDto : class
    where TUpdateDto : class
    {
        Task TInsertAsync(TAddDto dto);
        Task TUpdateAsync(TUpdateDto dto);
        Task TDeleteAsync(int id);
    }
}
