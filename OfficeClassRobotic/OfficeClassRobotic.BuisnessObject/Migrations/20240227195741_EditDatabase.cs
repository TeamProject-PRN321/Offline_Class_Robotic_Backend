using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class EditDatabase : Migration
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
                    StatusOfDevice = table.Column<bool>(type: "bit", nullable: true),
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
                    AttendaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"), "23 Hcm", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhn537@gmail.com", "Nguyen Thanh Nhan", "Male", new byte[] { 188, 172, 80, 207, 148, 83, 176, 234, 182, 90, 250, 5, 54, 45, 60, 80, 4, 3, 126, 116, 73, 108, 5, 29, 0, 8, 47, 25, 180, 42, 8, 51, 117, 190, 6, 131, 194, 111, 142, 158, 76, 54, 215, 36, 220, 106, 148, 129, 241, 37, 214, 42, 249, 146, 229, 52, 217, 231, 254, 228, 123, 42, 0, 182 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 }, "0912345678", "132564487asjdhkahsdkj", "nhannt" },
                    { new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"), "23 Hcm", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lylynp537@gmail.com", "Nguyen Phuong LyLy", "Female", new byte[] { 188, 172, 80, 207, 148, 83, 176, 234, 182, 90, 250, 5, 54, 45, 60, 80, 4, 3, 126, 116, 73, 108, 5, 29, 0, 8, 47, 25, 180, 42, 8, 51, 117, 190, 6, 131, 194, 111, 142, 158, 76, 54, 215, 36, 220, 106, 148, 129, 241, 37, 214, 42, 249, 146, 229, 52, 217, 231, 254, 228, 123, 42, 0, 182 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 }, "0912345678", "132564487asjdhkahsdkj", "lylynp" },
                    { new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"), "23 Hcm", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vinnt537@gmail.com", "Nguyen Ngoc Thai Vi", "Male", new byte[] { 188, 172, 80, 207, 148, 83, 176, 234, 182, 90, 250, 5, 54, 45, 60, 80, 4, 3, 126, 116, 73, 108, 5, 29, 0, 8, 47, 25, 180, 42, 8, 51, 117, 190, 6, 131, 194, 111, 142, 158, 76, 54, 215, 36, 220, 106, 148, 129, 241, 37, 214, 42, 249, 146, 229, 52, 217, 231, 254, 228, 123, 42, 0, 182 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 }, "0912345678", "132564487asjdhkahsdkj", "vinnt" },
                    { new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vinnt060402@gmail.com", "Nguyễn Ngọc Thái Vĩ", "Male", new byte[] { 178, 160, 139, 138, 93, 61, 145, 192, 0, 232, 113, 193, 246, 29, 125, 233, 125, 13, 48, 163, 2, 193, 84, 77, 134, 130, 49, 5, 27, 20, 65, 124, 118, 175, 145, 11, 202, 36, 72, 207, 7, 99, 77, 254, 34, 63, 210, 148, 232, 236, 202, 118, 3, 193, 107, 121, 234, 90, 10, 68, 148, 187, 160, 165 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 }, "0123456789", "abc", "vinnt060402" }
                });

            migrationBuilder.InsertData(
                table: "GiaoTrinhs",
                columns: new[] { "Id", "CreateBy", "Created", "Description", "FilePDF", "GiaoTrinhName", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"), null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(3974), "", "firebaseStorage", "Toan cao cap 10", false, null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3898), false, null, null, "Parent" },
                    { new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3907), false, null, null, "Teacher" },
                    { new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3904), false, null, null, "Admin" },
                    { new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3911), false, null, null, "TrungTamRobotic" },
                    { new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3892), false, null, null, "Student" },
                    { new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3901), false, null, null, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "TrungTamRobotics",
                columns: new[] { "Id", "Address", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[] { new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"), "123 Nguyễn Ảnh Thủ, Hóc Môn", null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4548), false, null, null, "Trung Tâm Robotic cơ sở 3" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("77d7d079-b309-424c-a62b-3f942caedc20"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3830), false, null, null });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "AppUserId", "RoleId" },
                values: new object[] { new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128") });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "ClassRoomName", "CreateBy", "Created", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "TrungTamRoboticId" },
                values: new object[] { new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"), "P.403", null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4519), "Tầng 4, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "ParentId" },
                values: new object[] { new Guid("2b9d9aca-27da-415b-a468-b367613a2488"), new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"), null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(5380), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreateBy", "Created", "GiaoTrinhId", "IsDeleted", "LastModified", "LastModifiedBy", "SubjectName", "TotalSlots" },
                values: new object[] { new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"), null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4235), new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"), false, null, null, "Toan 10", 21 });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"), new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"), null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4348), false, null, null },
                    { new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"), new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"), null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4325), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName", "CreateBy", "Created", "DayStudy", "EndTime", "IsDeleted", "LastModified", "LastModifiedBy", "StartTime", "StudentId", "SubjectId" },
                values: new object[] { new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"), "SE1603", null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4272), "Thứ 2;Thứ 4", new TimeSpan(0, 18, 0, 0, 0), false, null, null, new TimeSpan(0, 15, 0, 0, 0), new Guid("2b9d9aca-27da-415b-a468-b367613a2488"), new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57") });

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
                columns: new[] { "Id", "ClassId", "ClassRoomID", "CreateBy", "Created", "DateStudy", "IsDeleted", "LastModified", "LastModifiedBy", "NumberOfSudent", "TeacherId" },
                values: new object[] { new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"), new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"), new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"), null, new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4483), new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4486), false, null, null, 40, new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505") });

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
