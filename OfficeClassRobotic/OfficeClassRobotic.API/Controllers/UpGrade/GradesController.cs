using Microsoft.AspNetCore.Mvc;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.SudentGrades;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.Repository.IStudentGrades;
using OfficeClassRobotic.Repository.Teachers;
using OfficeOpenXml;
using System.Diagnostics;

namespace OfficeClassRobotic.API.Controllers.UpGrade
{
    [Route("api/v1/grade")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private IStudentGradeRepository _repo;

        public GradesController(IStudentGradeRepository repo)
        {
            _repo = repo;
        }
        /*[HttpPost]
        public async Task<IActionResult> CreateExcel()
        {
            var fileName = "Danh_sach.xlsx";

            // Tạo file Excel mới
            using (var package = new ExcelPackage())
            {
                // Tạo sheet
                var sheet = package.Workbook.Worksheets.Add("Danh sách");

                // Định dạng header
                var headerRow = sheet.Cells[1, 1, 1, 2];
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Fill.PatternType = ExcelFillPatternType.Solid;
                headerRow.Style.Fill.BackgroundColor.SetColor(Color.Blue);

                // Thêm dữ liệu
                sheet.Cells[1, 1].Value = "Tên";
                sheet.Cells[1, 2].Value = "Tuổi";

                // Thêm dữ liệu mẫu
                sheet.Cells[2, 1].Value = "Nguyễn Văn A";
                sheet.Cells[2, 2].Value = 20;
                sheet.Cells[3, 1].Value = "Trần Thị B";
                sheet.Cells[3, 2].Value = 25;

                // Định dạng cột "Tuổi"
                var ageColumn = sheet.Cells[1, 2, sheet.Dimension.End.Row, 2];
                ageColumn.Style.Fill.PatternType = ExcelFillPatternType.Solid;
                ageColumn.Style.Fill.BackgroundColor.SetColor(Color.Red);

                // Lưu file
                var bytes = package.GetAsByteArray();

                // Trả về file
                return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }*/

        [HttpGet]
        [Route("download/excel")]
        public async Task<IActionResult> DownloadExcel()
        {
            // Đường dẫn tới file Excel trong hệ thống của bạn
            string filePath = "path_to_your_excel_file.xlsx";

            // Đọc dữ liệu từ file Excel vào một byte array
            byte[] fileBytes = await System.IO.File.ReadAllBytesAsync(filePath);

            // Trả về file Excel dưới dạng response của API
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "excel_file.xlsx");
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateClassroom([FromBody] CreateClassStudentExcel classroom)
        {
            try
            {
                // Tạo một đối tượng ExcelPackage
                using (ExcelPackage package = new ExcelPackage())
                {
                    // Tạo một worksheet
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Students");

                    // HEader cho table
                    worksheet.Cells[1, 1].Value = "Mã SV";
                    worksheet.Cells[1, 2].Value = "Tên Sinh viên";
                    worksheet.Cells[1, 3].Value = "Email";
                    worksheet.Cells[1, 4].Value = "Điểm";

                    // Format header
                    using (var range = worksheet.Cells["A1:D1"])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Font.Size = 12;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    // Ghi dữ liệu từ danh sách sinh viên vào file Excel
                    int rowIndex = 2;
                    foreach (var student in classroom.StudentListIds)
                    {
                        worksheet.Cells[rowIndex, 1].Value = student.StudentId;
                        worksheet.Cells[rowIndex, 2].Value = student.StudentName;
                        worksheet.Cells[rowIndex, 3].Value = student.Email;
                        worksheet.Cells[rowIndex, 4].Value = student.Score;
                        rowIndex++;
                    }

                    // Autofit columns
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Lưu file Excel
                    var directoryPath = @"D:\Classromm\";
                    var filePath = Path.Combine(directoryPath, $"{classroom.ClassName}_Students.xlsx");
                    System.IO.File.WriteAllBytes(filePath, package.GetAsByteArray());
                }

                return Ok("File Excel đã được tạo thành công.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("get-list-student-of-class/{classname}")]
        public async Task<List<StudentGradeDTO>> GetListStudentOfClassByClassName(string classname)
        {
            var result = await _repo.GetStudentOfClassWithTemplateExcel(classname);
            return result;

        }

        [HttpGet]
        [Route("get-list-grade/{classname}")]
        public async Task<IActionResult> GetListTeacherBySubject(string classname)
        {
            var result = await _repo.GetStudentOfClassWithTemplateExcel(classname);
            try
            {
                // Tạo một đối tượng ExcelPackage
                using (ExcelPackage package = new ExcelPackage())
                {
                    // Tạo một worksheet
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Students");

                    // HEader cho table
                    worksheet.Cells[1, 1].Value = "Mã SV";
                    worksheet.Cells[1, 2].Value = "Tên Sinh viên";
                    worksheet.Cells[1, 3].Value = "Email";
                    worksheet.Cells[1, 4].Value = "Kiem tra 15p";
                    worksheet.Cells[1, 5].Value = "Kiem tra 1T";

                    // Format header
                    using (var range = worksheet.Cells["A1:E1"])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Font.Size = 18;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    // Ghi dữ liệu từ danh sách sinh viên vào file Excel
                    int rowIndex = 2;
                    foreach (var student in result)
                    {
                        worksheet.Cells[rowIndex, 1].Value = student.StudentId;
                        worksheet.Cells[rowIndex, 2].Value = student.StudentName;
                        worksheet.Cells[rowIndex, 3].Value = student.Email;

                        foreach (var grade in student.GradeSubjectOfStudents)
                        {
                            if (grade.AssesessmentType == "Kiem tra 15p")
                            {
                                worksheet.Cells[rowIndex, 4].Value = grade.Grade;
                            }
                            if (grade.AssesessmentType == "Kiem tra 1T")
                            {
                                worksheet.Cells[rowIndex, 5].Value = grade.Grade;
                            }
                        }
                        rowIndex++;
                    }

                    // Autofit columns
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    /*          // Lưu file Excel
                              var directoryPath = @"C:\Users\ADMIN\Downloads";
                              var filePath = Path.Combine(directoryPath, $"{classname}_Students.xlsx");
                              System.IO.File.WriteAllBytes(filePath, package.GetAsByteArray());*/

                    var filePath = $"{classname}_Students.xlsx";


                    // Lưu file
                    var bytes = package.GetAsByteArray();

                    // Trả về file
                    return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filePath);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("get-list-grade-of-student/{classname}")]
        public async Task<IActionResult> GetScoreOfStudentByClassname(string classname)
        {
            var result = await _repo.GetScoreOfStudentByClassname(classname);
            return Ok(result);
        }

        [HttpPost]
        [Route("api/upload/excel")]
        public async Task<IActionResult> UploadExcel([FromForm] IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                try
                {
                    string fileName = file.FileName;

                    // Tách tên lớp học từ tên file
                    string[] parts = fileName.Split('_');
                    if (parts.Length >= 2)
                    {
                        string className = parts[0];
                        var subject = await _repo.GetSubjectByClassName(className);
                        var subjectId = subject.Id;

                        // Đọc dữ liệu từ file Excel
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            memoryStream.Position = 0;

                            // Xử lý dữ liệu từ file Excel, ví dụ: lưu vào database
                            // đọc dữ liệu từ file Excel và lưu vào database

                            // Ví dụ: Sử dụng EPPlus để đọc dữ liệu từ file Excel
                            using (var package = new ExcelPackage(memoryStream))
                            {
                                var workbook = package.Workbook;
                                var worksheet = workbook.Worksheets.FirstOrDefault();

                                if (worksheet != null)
                                {
                                    int rowCount = worksheet.Dimension.Rows;
                                    int columnCount = worksheet.Dimension.Columns;

                                    for (int row = 2; row <= rowCount; row++)
                                    {
                                        // Đọc dữ liệu từ từng ô trong hàng hiện tại
                                        string studentId = worksheet.Cells[row, 1].Value?.ToString();
                                        string studentName = worksheet.Cells[row, 2].Value?.ToString();
                                        string email = worksheet.Cells[row, 3].Value?.ToString();

                                        var listGrade = new List<GradeSubjectOfStudent>();
                                        for (int column = 4; column <= columnCount; column++)
                                        {
                                            double? gradeValue = double.Parse(worksheet.Cells[row, column].Value?.ToString());
                                            var assessmentType = worksheet.Cells[1, column].Value?.ToString();

                                            var addGradeFromExcel = new GradeSubjectOfStudent
                                            {
                                                SubjetcId = subjectId,
                                                AssesessmentType = worksheet.Cells[1, column].Value?.ToString(),
                                                WeightPercentage = GetWeightPercentage(assessmentType),
                                                Grade = gradeValue.Value,
                                            };

                                            listGrade.Add(addGradeFromExcel);
                                        }
                                        // Lưu dữ liệu vào cơ sở dữ liệu
                                        await _repo.SaveToDatabase(studentId, listGrade, className);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        return BadRequest("Invalid file name format.");
                    }

                    return Ok("File uploaded successfully.");
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex}");
                }
            }
            else
            {
                return BadRequest("No file uploaded.");
            }
        }

        private int GetWeightPercentage(string assessmentType)
        {
            switch (assessmentType)
            {
                case "Kiem tra 15p":
                    return 15;
                case "Kiem tra 1T":
                    return 20;
                
                default:
                    return 0;
            }
        }
    }
}
