using System;

namespace IQSoftTestApi.Features.ExcelService
{
    public class IncorrectExcelFileFormatException : Exception
    {
        public IncorrectExcelFileFormatException() : base("Input file was in incorrect format, please check this file")
        {
            
        }
    }
}
