namespace Traversal.BusinessLayer.Abstracts
{
    public interface IExcelService
    {
        byte[] ExcelList<T>(List<T> t) where T : class;
    }
}
