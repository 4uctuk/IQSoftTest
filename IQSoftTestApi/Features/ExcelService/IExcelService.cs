using System.IO;
using System.Threading.Tasks;

namespace IQSoftTestApi.Features.ExcelService
{
    public interface IExcelService
    {
        Task ImportSpreadSheetToDatabase(Stream openReadStream);
    }
}
