namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGenericReadonlyService<TDto, TListDto>
    where TDto : class
    where TListDto : class
    {
        List<TListDto> TGetList();
        TDto TGetById(int id);
    }
}
