using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQSoftTestApi.Features.ExcelService
{
    [ApiController]
    [Route("excel")]
    public class ExcelUploadController : ControllerBase
    {
        private readonly IExcelService _excelService;

        public ExcelUploadController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        [HttpPost("upload")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.UnprocessableEntity)]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                try
                {
                    await _excelService.ImportSpreadSheetToDatabase(uploadedFile.OpenReadStream());
                    return Ok();
                }
                catch (IncorrectExcelFileFormatException e)
                {
                    return StatusCode((int) HttpStatusCode.BadRequest, e.Message);
                }
                catch (Exception e)
                {
                    return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
                }
            }

            return StatusCode((int) HttpStatusCode.UnprocessableEntity, "Upload file missing");
        }
    }
}
