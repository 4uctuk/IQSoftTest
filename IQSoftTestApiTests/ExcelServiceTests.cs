using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IQSoftTestApi.Features.DataContext;
using IQSoftTestApi.Features.ExcelService;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IQSoftTestApiTests
{
    [TestClass]
    public class ExcelServiceTests
    {
        [TestMethod]
        public async Task Excel_File_Parses_ToDataBase_Correctly()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "Excel_File_Parses_ToDataBase_Correctly")
                .Options;

            var openFileStream = File.OpenRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestTable.xlsx"));
            
            using (var context = new ApplicationDbContext(options))
            {
                var service = new ExcelService(context);
                await service.ImportSpreadSheetToDatabase(openFileStream);
            }

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new ApplicationDbContext(options))
            {
                Assert.AreEqual(2, context.FirstTestEntities.Count());
                Assert.AreEqual(2, context.SecondTestEntities.Count());
                var firstItemEntity = await context.FirstTestEntities.FirstOrDefaultAsync(c => c.ItemId == 1);
                Assert.IsNotNull(firstItemEntity);
                Assert.AreEqual("Sheet1Col16Id1", firstItemEntity.Col16Item);
                var secondSheetSecondEntity = await context.SecondTestEntities.FirstOrDefaultAsync(c => c.ItemId == 22);
                Assert.IsNotNull(secondSheetSecondEntity);
                Assert.AreEqual("Sheet2Col11Id2",secondSheetSecondEntity.Col11Item);
            }
        }
    }
}
