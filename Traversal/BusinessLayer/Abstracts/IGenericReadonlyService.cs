namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGenericReadonlyService<TEntity, TDto, TListDto>
    where TDto : class
    where TListDto : class
    {
        Task<List<TListDto>> TGetListAsync();
        Task<TDto> TGetByIdAsync(int id);
    }
}
