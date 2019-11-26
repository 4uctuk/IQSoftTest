using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using IQSoftTestApi.Features.DataContext;
using IQSoftTestApi.Features.DataContext.Model;

namespace IQSoftTestApi.Features.ExcelService
{
    public class ExcelService : IExcelService
    {
        private readonly ApplicationDbContext _context;

        public ExcelService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task ImportSpreadSheetToDatabase(Stream openReadStream)
        {
            using (var spreadsheetDocument = SpreadsheetDocument.Open(openReadStream, false))
            {
                var workbookPart = spreadsheetDocument.WorkbookPart;
                var firstPart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
                var firstWorksheet = workbookPart.WorksheetParts.First();
                FillEntity<FirstTestEntity>(firstPart, firstWorksheet);
                var secondPart = workbookPart.GetPartsOfType<SharedStringTablePart>().Last();
                var secondWorkSheet = workbookPart.WorksheetParts.Last();
                FillEntity<SecondTestEntity>(secondPart, secondWorkSheet);
            }

            await _context.SaveChangesAsync();
        }

        private void FillEntity<T>(SharedStringTablePart tablePart, WorksheetPart worksheetPart) where T : BaseEntity, new()
        {
            var sst = tablePart.SharedStringTable;
            var sheet = worksheetPart.Worksheet;
            var rows = sheet.Descendants<Row>();
            
            var counter = 0;
            foreach (var row in rows)
            {
                //skip first row
                if (counter == 0)
                {
                    counter++;
                    continue;
                }

                var cells = row.Descendants<Cell>();

                var entity = new T();

                var cellsCounter = 1;
                foreach (var cell in cells)
                {
                    if (cellsCounter > 20)
                    {
                        throw new IncorrectExcelFileFormatException();
                    }

                    if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
                    {
                        var sId = int.Parse(cell.CellValue.Text);
                        var cellElement = sst.ChildElements[sId];
                        var value = cellElement.InnerText;
                        FillEntityProperty<T>(entity, cellsCounter, value);
                    }
                    else if (cell.CellValue != null)
                    {
                        if (float.TryParse(cell.CellValue.InnerText, NumberStyles.Any, CultureInfo.InvariantCulture,
                            out var result))
                        {
                            entity.ItemId = (int) result;
                        }
                        else
                        {
                            throw new IncorrectExcelFileFormatException();
                        }
                    }

                    cellsCounter++;
                }

                if(CheckIfExisting<T>(entity.ItemId))
                    continue;
                _context.Add(entity);
            }
        }

        private bool CheckIfExisting<T>(int id) where T : BaseEntity, new()
        {
            switch (typeof(T).Name)
            {
                case nameof(FirstTestEntity):
                    return _context.FirstTestEntities.Any(c => c.ItemId == id);
                case nameof(SecondTestEntity):
                    return _context.SecondTestEntities.Any(c => c.ItemId == id);
                default:
                    throw new InvalidOperationException("Type of entity doesn't exist");
            }
        }

        private static void FillEntityProperty<T>(T entity, in int cellsCounter, string value) where T : BaseEntity, new()
        {
            switch (typeof(T).Name)
            {
                case nameof(FirstTestEntity):
                    var firstTestEntity = entity as FirstTestEntity;
                    if (firstTestEntity == null)
                    {
                        throw new InvalidOperationException("Can't cast entity to FirstTestEntity");
                    }
                    FillFirstEntityProperty(firstTestEntity, cellsCounter, value);
                    break;
                case nameof(SecondTestEntity):
                    var secondTestEntity = entity as SecondTestEntity;
                    if (secondTestEntity == null)
                    {
                        throw new InvalidOperationException("Can't cast entity to FirstTestEntity");
                    }
                    FillSecondEntityProperty(secondTestEntity, cellsCounter, value);
                    break;
            }
        }

        private static void FillSecondEntityProperty(SecondTestEntity secondTestEntity, int cellsCounter, string value)
        {
            switch (cellsCounter)
            {
                case 2:
                    secondTestEntity.Col2Item = value;
                    break;
                case 3:
                    secondTestEntity.Col3Item = value;
                    break;
                case 4:
                    secondTestEntity.Col4Item = value;
                    break;
                case 5:
                    secondTestEntity.Col5Item = value;
                    break;
                case 6:
                    secondTestEntity.Col6Item = value;
                    break;
                case 7:
                    secondTestEntity.Col7Item = value;
                    break;
                case 8:
                    secondTestEntity.Col8Item = value;
                    break;
                case 9:
                    secondTestEntity.Col9Item = value;
                    break;
                case 10:
                    secondTestEntity.Col10Item = value;
                    break;
                case 11:
                    secondTestEntity.Col11Item = value;
                    break;
                case 12:
                    secondTestEntity.Col12Item = value;
                    break;
                case 13:
                    secondTestEntity.Col13Item = value;
                    break;
                case 14:
                    secondTestEntity.Col14Item = value;
                    break;
                case 15:
                    secondTestEntity.Col15Item = value;
                    break;
                case 16:
                    secondTestEntity.Col16Item = value;
                    break;
                case 17:
                    secondTestEntity.Col17Item = value;
                    break;
                case 18:
                    secondTestEntity.Col18Item = value;
                    break;
                case 19:
                    secondTestEntity.Col19Item = value;
                    break;
                case 20:
                    secondTestEntity.Col20Item = value;
                    break;
            }
        }

        private static void FillFirstEntityProperty(FirstTestEntity firstTestEntity, int cellsCounter, string value)
        {
           switch (cellsCounter)
            {
                case 2:
                    firstTestEntity.Col2Item = value;
                    break;
                case 3:
                    firstTestEntity.Col3Item = value;
                    break;
                case 4:
                    firstTestEntity.Col4Item = value;
                    break;
                case 5:
                    firstTestEntity.Col5Item = value;
                    break;
                case 6:
                    firstTestEntity.Col6Item = value;
                    break;
                case 7:
                    firstTestEntity.Col7Item = value;
                    break;
                case 8:
                    firstTestEntity.Col8Item = value;
                    break;
                case 9:
                    firstTestEntity.Col9Item = value;
                    break;
                case 10:
                    firstTestEntity.Col10Item = value;
                    break;
                case 11:
                    firstTestEntity.Col11Item = value;
                    break;
                case 12:
                    firstTestEntity.Col12Item = value;
                    break;
                case 13:
                    firstTestEntity.Col13Item = value;
                    break;
                case 14:
                    firstTestEntity.Col14Item = value;
                    break;
                case 15:
                    firstTestEntity.Col15Item = value;
                    break;
                case 16:
                    firstTestEntity.Col16Item = value;
                    break;
                case 17:
                    firstTestEntity.Col17Item = value;
                    break;
                case 18:
                    firstTestEntity.Col18Item = value;
                    break;
                case 19:
                    firstTestEntity.Col19Item = value;
                    break;
                case 20:
                    firstTestEntity.Col20Item = value;
                    break;
            }
        }
    }
}
