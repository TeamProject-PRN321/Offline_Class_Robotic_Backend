using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase133 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PassWordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiaoTrinhs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaoTrinhName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoTrinhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrungTamRobotics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrungTamRobotics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefreshTOken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JwtId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsageCount = table.Column<int>(type: "int", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    IssuedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSlots = table.Column<int>(type: "int", nullable: false),
                    GiaoTrinhId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_GiaoTrinhs_GiaoTrinhId",
                        column: x => x.GiaoTrinhId,
                        principalTable: "GiaoTrinhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.RoleId, x.AppUserId });
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassRoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrungTamRoboticId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classrooms_TrungTamRobotics_TrungTamRoboticId",
                        column: x => x.TrungTamRoboticId,
                        principalTable: "TrungTamRobotics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeedBackName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayStudy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsClassFinish = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Classes_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubjectGradingWeights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssesessmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightPercentage = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectGradingWeights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectGradingWeights_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSubjects",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjects", x => new { x.SubjectId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceOfDevice = table.Column<double>(type: "float", nullable: true),
                    StatusOfDevice = table.Column<int>(type: "int", nullable: false),
                    ClassRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Classrooms_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ClassSchedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateStudy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfSudent = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassRoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSchedule_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ClassSchedule_Classrooms_ClassRoomID",
                        column: x => x.ClassRoomID,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ClassSchedule_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StudentGrades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssesessmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentGrades_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendStatus = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassScheduleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendance_ClassSchedule_ClassScheduleID",
                        column: x => x.ClassScheduleID,
                        principalTable: "ClassSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FullName", "Gender", "PassWordHash", "PassWordSalt", "PhoneNumber", "PhotoUrl", "UserName" },
                values: new object[,]
                {
                    { new Guid("275c605e-3d04-437d-8a7d-208249412cec"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi1@gmail.com", "Vĩ 1", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vi1" },
                    { new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"), "23 Hcm", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhn537@gmail.com", "Nguyen Thanh Nhan", "Male", new byte[] { 245, 44, 113, 3, 223, 64, 74, 157, 7, 13, 148, 201, 2, 27, 129, 22, 99, 47, 50, 223, 34, 103, 53, 192, 230, 207, 226, 217, 21, 161, 223, 244, 80, 56, 45, 13, 111, 61, 37, 89, 25, 46, 128, 64, 76, 104, 248, 93, 13, 84, 36, 94, 42, 236, 180, 80, 242, 243, 94, 213, 135, 189, 3, 99 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0912345678", "132564487asjdhkahsdkj", "nhannt" },
                    { new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"), "23 Hcm", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lylynp537@gmail.com", "Nguyen Phuong LyLy", "Female", new byte[] { 245, 44, 113, 3, 223, 64, 74, 157, 7, 13, 148, 201, 2, 27, 129, 22, 99, 47, 50, 223, 34, 103, 53, 192, 230, 207, 226, 217, 21, 161, 223, 244, 80, 56, 45, 13, 111, 61, 37, 89, 25, 46, 128, 64, 76, 104, 248, 93, 13, 84, 36, 94, 42, 236, 180, 80, 242, 243, 94, 213, 135, 189, 3, 99 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0912345678", "132564487asjdhkahsdkj", "lylynp" },
                    { new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi2@gmail.com", "Vĩ 2", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vi2" },
                    { new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi5@gmail.com", "Vĩ 5", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vi5" },
                    { new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi3@gmail.com", "Vĩ 3", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vi3" },
                    { new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi7@gmail.com", "Vĩ 7", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vi7" },
                    { new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi6@gmail.com", "Vĩ 1", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vi1" },
                    { new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi4@gmail.com", "Vĩ 4", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vi4" },
                    { new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"), "23 Hcm", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vinnt537@gmail.com", "Nguyen Ngoc Thai Vi", "Male", new byte[] { 245, 44, 113, 3, 223, 64, 74, 157, 7, 13, 148, 201, 2, 27, 129, 22, 99, 47, 50, 223, 34, 103, 53, 192, 230, 207, 226, 217, 21, 161, 223, 244, 80, 56, 45, 13, 111, 61, 37, 89, 25, 46, 128, 64, 76, 104, 248, 93, 13, 84, 36, 94, 42, 236, 180, 80, 242, 243, 94, 213, 135, 189, 3, 99 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0912345678", "132564487asjdhkahsdkj", "vinnt" },
                    { new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vinnt060402@gmail.com", "Nguyễn Ngọc Thái Vĩ", "Male", new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 }, "0123456789", "abc", "vinnt060402" }
                });

            migrationBuilder.InsertData(
                table: "GiaoTrinhs",
                columns: new[] { "Id", "CreateBy", "Created", "Description", "FilePDF", "GiaoTrinhName", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"), null, new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(1769), "", "firebaseStorage", "Toan cao cap 10", false, null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5161), false, null, null, "Parent" },
                    { new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5175), false, null, null, "Teacher" },
                    { new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5166), false, null, null, "Admin" },
                    { new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5177), false, null, null, "TrungTamRobotic" },
                    { new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5157), false, null, null, "Student" },
                    { new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5164), false, null, null, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "TrungTamRobotics",
                columns: new[] { "Id", "Address", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[] { new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"), "123 Nguyễn Ảnh Thủ, Hóc Môn", null, new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2045), false, null, null, "Trung Tâm Robotic cơ sở 3" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("9c20d30e-ff04-4d21-a14f-ec6b5888a880"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5133), false, null, null });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "AppUserId", "RoleId" },
                values: new object[] { new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128") });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "ClassRoomName", "CreateBy", "Created", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "TrungTamRoboticId" },
                values: new object[,]
                {
                    { new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"), "P.203", null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5342), "Tầng 2, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") },
                    { new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"), "P.303", null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5338), "Tầng 3, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") },
                    { new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"), "P.103", null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5349), "Tầng 1, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") },
                    { new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"), "P.403", null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5334), "Tầng 4, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "ParentId" },
                values: new object[,]
                {
                    { new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"), new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5304), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"), new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5307), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2b9d9aca-27da-415b-a468-b367613a2488"), new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"), null, new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2203), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"), new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5292), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"), new Guid("275c605e-3d04-437d-8a7d-208249412cec"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5309), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"), new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5302), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"), new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5296), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"), new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5299), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreateBy", "Created", "GiaoTrinhId", "IsDeleted", "LastModified", "LastModifiedBy", "SubjectName", "TotalSlots" },
                values: new object[] { new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"), null, new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(1990), new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"), false, null, null, "Toan 10", 21 });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"), new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5372), false, null, null },
                    { new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"), new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5368), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName", "CreateBy", "Created", "DayStudy", "EndTime", "IsClassFinish", "IsDeleted", "LastModified", "LastModifiedBy", "StartTime", "StudentId", "SubjectId" },
                values: new object[] { new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"), "SE1603", null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5409), "Thứ 2;Thứ 4", new TimeSpan(0, 18, 0, 0, 0), false, false, null, null, new TimeSpan(0, 15, 0, 0, 0), new Guid("2b9d9aca-27da-415b-a468-b367613a2488"), new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57") });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "ClassRoomId", "CreateBy", "Created", "Description", "DeviceName", "IsDeleted", "LastModified", "LastModifiedBy", "PriceOfDevice", "StatusOfDevice" },
                values: new object[,]
                {
                    { new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"), new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5459), "Ghế 1 người ngồi", "Ghế", false, null, null, 200000.0, 1 },
                    { new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"), new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5449), "bàn 1 người ngồi", "Bàn học", false, null, null, 120000.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "TeacherSubjects",
                columns: new[] { "SubjectId", "TeacherId", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"), new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"), false },
                    { new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"), new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"), false }
                });

            migrationBuilder.InsertData(
                table: "ClassSchedule",
                columns: new[] { "Id", "ClassId", "ClassRoomID", "CreateBy", "Created", "DateStudy", "EndTime", "IsDeleted", "LastModified", "LastModifiedBy", "NumberOfSudent", "StartTime", "TeacherId" },
                values: new object[] { new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"), new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"), new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"), null, new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2017), null, false, null, null, 40, null, new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505") });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AppUserId",
                table: "Admins",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_AppUserId",
                table: "AppUserRoles",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_ClassScheduleID",
                table: "Attendance",
                column: "ClassScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_StudentId",
                table: "Classes",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SubjectId",
                table: "Classes",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_TrungTamRoboticId",
                table: "Classrooms",
                column: "TrungTamRoboticId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedule_ClassId",
                table: "ClassSchedule",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedule_ClassRoomID",
                table: "ClassSchedule",
                column: "ClassRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedule_TeacherId",
                table: "ClassSchedule",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ClassRoomId",
                table: "Devices",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_TeacherId",
                table: "FeedBacks",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_AppUserId",
                table: "Parents",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_AppUserId",
                table: "RefreshToken",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_AppUserId",
                table: "Staffs",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_ClassId",
                table: "StudentGrades",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AppUserId",
                table: "Students",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectGradingWeights_SubjectID",
                table: "SubjectGradingWeights",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_GiaoTrinhId",
                table: "Subjects",
                column: "GiaoTrinhId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_AppUserId",
                table: "Teacher",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_TeacherId",
                table: "TeacherSubjects",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "StudentGrades");

            migrationBuilder.DropTable(
                name: "SubjectGradingWeights");

            migrationBuilder.DropTable(
                name: "TeacherSubjects");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ClassSchedule");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "TrungTamRobotics");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "GiaoTrinhs");
        }
    }
}
