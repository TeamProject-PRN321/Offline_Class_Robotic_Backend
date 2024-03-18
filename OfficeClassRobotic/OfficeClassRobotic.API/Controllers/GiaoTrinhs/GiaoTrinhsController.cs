using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.Repository.GiaoTrinhForSubject;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.Repository.GiaoTrinhs;
using Microsoft.Data.SqlClient;
using Azure.Core;
using Models.OfficeClassRobotic.BuisnessObject;
using Microsoft.AspNetCore.Http.HttpResults;

namespace OfficeClassRobotic.API.Controllers.GiaoTrinhs
{
    [Route("api/v1/giao-trinh")]
    [ApiController]
    public class GiaoTrinhsController : ControllerBase
    {
        private readonly IGiaoTrinhRepository _giaoTrinhRepository;
        public GiaoTrinhsController(IGiaoTrinhRepository giaoTrinhRepository)
        {
            _giaoTrinhRepository = giaoTrinhRepository;
        }
        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateGiaoTrinhCommand request)
        {
            var result = _giaoTrinhRepository.CreateGiaoTrinh(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> Update(UpdateGiaoTrinhCommand request)
        {
            var result = _giaoTrinhRepository.UpdateGiaoTrinh(request);
            return result;
        }

        [HttpDelete]
        [Route("remove")]
        public Task<ClassRoboticResponse> Delete(DeleteGiaoTrinhCommand request)
        {
            var result = _giaoTrinhRepository.DeleteGiaoTrinh(request);
            return result;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<GiaoTrinhResponse>> GetAll()
        {
            var result = _giaoTrinhRepository.GetAllGiaoTrinh();
            return result;
        }

        [HttpGet]
        [Route("{giaoTrinhId}")]
        public async Task<IActionResult> GetById(string giaoTrinhId)
        {
            try
            {
                var result = await _giaoTrinhRepository.GetGiaoTrinhById(giaoTrinhId);
                // ổ C
                string directoryPath = @"C:\Users\ADMIN\Downloads";

                // tạo thư mục
                Directory.CreateDirectory(directoryPath);

                string filePath = Path.Combine(directoryPath, $"{result.FilePDFName}");

                System.IO.File.WriteAllBytes(filePath, result.FilePDF);

                return Ok($"Tệp PDF đã được tải về thành công và lưu tại {filePath}");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và trả về lỗi
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("pdfs/{subjectId}")]
        public async Task<IActionResult> GetPdfFiles(string subjectId)
        {
            try
            {
                var pdfList = await _giaoTrinhRepository.GetPdfFilesFromDatabase(subjectId);
                var response = new List<FileContentResult>();
                foreach (var file in pdfList)
                {
                    string directoryPath = @"C:\Users\ADMIN\Downloads";

                    // tạo thư mục
                    Directory.CreateDirectory(directoryPath);

                    string filePath = Path.Combine(directoryPath, $"{file.FilePDFName}");

                    System.IO.File.WriteAllBytes(filePath, file.FilePDF);

                    /*var filePDFResponse = new FileContentResult(file.FilePDF, "application/pdf")
                    {
                        FileDownloadName = file.FilePDFName
                    };
                    response.Add(filePDFResponse);*/
                }
                return Ok($"Tệp PDF đã được tải về thành công");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }

        }


        [HttpPost("uploadpdfs")]
        public async Task<IActionResult> UploadPdfFiles(List<IFormFile> files, [FromForm] CreateGiaoTrinhCommands command)
        {
            try
            {
                var listFilePDFs = new List<CreateFilePDFs>();
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        // Đọc dữ liệu từ tệp PDF
                        using (var ms = new MemoryStream())
                        {
                            await file.CopyToAsync(ms);
                            byte[] pdfData = ms.ToArray();
                            var newCreateFile = new CreateFilePDFs
                            {
                                FilePDFName = file.FileName,
                                FilePDF = pdfData
                            };

                            listFilePDFs.Add(newCreateFile);
                        }
                    }
                }
                // Lưu dữ liệu vào cơ sở dữ liệu
                /*await SavePdfToDatabase(listFilePDFs);*/
                var request = new CreateGiaoTrinhCommand
                {
                    GiaoTrinhName = command.GiaoTrinhName,
                    Description = command.Description,
                    ListFilePDFs = listFilePDFs,
                    SubjectId = command.SubjectId,
                };

                var result = await _giaoTrinhRepository.CreateGiaoTrinh(request);

                return Ok("PDF files uploaded successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
        public class CreateGiaoTrinhCommands
        {
            public string? GiaoTrinhName { get; set; }
            public string? Description { get; set; }
            public string SubjectId { get; set; }
        }
    }
}
