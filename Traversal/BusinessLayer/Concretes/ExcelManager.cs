using OfficeOpenXml;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.BusinessLayer.Concretes
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExcelList<T>(List<T> collection) where T : class
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells["A1"].LoadFromCollection(collection, true, OfficeOpenXml.Table.TableStyles.Light10);

            return excel.GetAsByteArray();
        }
    }
}
