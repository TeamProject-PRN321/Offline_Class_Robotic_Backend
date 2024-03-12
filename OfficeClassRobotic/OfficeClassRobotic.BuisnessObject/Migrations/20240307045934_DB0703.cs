using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class DB0703 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("34521f3a-a7bf-4262-be95-63a247371583"));

            migrationBuilder.DropColumn(
                name: "AttendaceName",
                table: "Attendance");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "ClassSchedule",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "ClassSchedule",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttendStatus",
                table: "Attendance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("2635e2ac-8a45-4746-9be6-fc71c11b061f"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3067), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 60, 156, 86, 131, 213, 79, 201, 107, 82, 247, 163, 37, 106, 204, 116, 66, 120, 78, 193, 174, 94, 184, 174, 168, 114, 161, 141, 122, 248, 142, 240, 251, 178, 130, 96, 145, 64, 89, 164, 250, 122, 30, 186, 8, 156, 2, 126, 189, 91, 23, 102, 122, 93, 149, 76, 245, 18, 67, 121, 222, 239, 129, 12, 206 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 60, 156, 86, 131, 213, 79, 201, 107, 82, 247, 163, 37, 106, 204, 116, 66, 120, 78, 193, 174, 94, 184, 174, 168, 114, 161, 141, 122, 248, 142, 240, 251, 178, 130, 96, 145, 64, 89, 164, 250, 122, 30, 186, 8, 156, 2, 126, 189, 91, 23, 102, 122, 93, 149, 76, 245, 18, 67, 121, 222, 239, 129, 12, 206 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 60, 156, 86, 131, 213, 79, 201, 107, 82, 247, 163, 37, 106, 204, 116, 66, 120, 78, 193, 174, 94, 184, 174, 168, 114, 161, 141, 122, 248, 142, 240, 251, 178, 130, 96, 145, 64, 89, 164, 250, 122, 30, 186, 8, 156, 2, 126, 189, 91, 23, 102, 122, 93, 149, 76, 245, 18, 67, 121, 222, 239, 129, 12, 206 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 } });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FullName", "Gender", "PassWordHash", "PassWordSalt", "PhoneNumber", "PhotoUrl", "UserName" },
                values: new object[,]
                {
                    { new Guid("275c605e-3d04-437d-8a7d-208249412cec"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi1@gmail.com", "Vĩ 1", "Male", new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 }, "0123456789", "abc", "vi1" },
                    { new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi2@gmail.com", "Vĩ 2", "Male", new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 }, "0123456789", "abc", "vi2" },
                    { new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi5@gmail.com", "Vĩ 5", "Male", new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 }, "0123456789", "abc", "vi5" },
                    { new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi3@gmail.com", "Vĩ 3", "Male", new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 }, "0123456789", "abc", "vi3" },
                    { new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi7@gmail.com", "Vĩ 7", "Male", new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 }, "0123456789", "abc", "vi7" },
                    { new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi6@gmail.com", "Vĩ 1", "Male", new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 }, "0123456789", "abc", "vi1" },
                    { new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"), "Long An", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi4@gmail.com", "Vĩ 4", "Male", new byte[] { 158, 251, 40, 62, 116, 208, 68, 69, 7, 205, 50, 58, 74, 205, 196, 97, 117, 230, 140, 168, 125, 197, 122, 60, 193, 231, 122, 51, 33, 91, 93, 10, 7, 212, 149, 220, 189, 121, 170, 116, 134, 54, 193, 249, 214, 199, 161, 199, 175, 230, 110, 220, 89, 225, 162, 68, 27, 233, 166, 253, 118, 39, 167, 246 }, new byte[] { 196, 213, 182, 249, 120, 90, 83, 13, 187, 247, 246, 112, 29, 133, 223, 29, 108, 225, 235, 143, 167, 173, 171, 145, 243, 26, 172, 9, 34, 96, 239, 62, 196, 36, 173, 248, 162, 177, 57, 228, 48, 34, 234, 93, 242, 128, 156, 163, 23, 110, 30, 64, 119, 7, 189, 72, 117, 139, 75, 196, 93, 132, 28, 118, 26, 137, 107, 65, 118, 1, 172, 206, 205, 207, 88, 92, 75, 201, 221, 161, 41, 122, 87, 141, 165, 132, 90, 247, 151, 52, 80, 13, 54, 196, 90, 111, 36, 213, 99, 200, 163, 174, 239, 25, 168, 166, 146, 202, 220, 245, 28, 96, 217, 47, 154, 180, 156, 155, 114, 154, 16, 197, 205, 162, 216, 135, 157, 121 }, "0123456789", "abc", "vi4" }
                });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 11, 59, 33, 908, DateTimeKind.Local).AddTicks(3629), new DateTime(2024, 3, 7, 11, 59, 33, 908, DateTimeKind.Local).AddTicks(3630), null, null });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 908, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 908, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 908, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 7, 11, 59, 33, 908, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "ParentId" },
                values: new object[,]
                {
                    { new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"), new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3205), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"), new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3208), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"), new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3192), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"), new Guid("275c605e-3d04-437d-8a7d-208249412cec"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3211), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"), new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3202), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"), new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3195), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"), new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"), null, new DateTime(2024, 3, 7, 11, 59, 33, 909, DateTimeKind.Local).AddTicks(3199), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2635e2ac-8a45-4746-9be6-fc71c11b061f"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"));

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "ClassSchedule");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "ClassSchedule");

            migrationBuilder.DropColumn(
                name: "AttendStatus",
                table: "Attendance");

            migrationBuilder.AddColumn<string>(
                name: "AttendaceName",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("34521f3a-a7bf-4262-be95-63a247371583"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6938), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 157, 36, 79, 129, 21, 225, 228, 127, 150, 245, 31, 82, 201, 250, 49, 201, 72, 232, 149, 212, 156, 158, 247, 133, 172, 230, 109, 132, 119, 198, 148, 184, 146, 213, 179, 173, 149, 17, 28, 203, 123, 72, 180, 220, 159, 161, 117, 71, 61, 8, 150, 19, 212, 42, 25, 133, 216, 205, 8, 191, 107, 43, 198, 100 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 157, 36, 79, 129, 21, 225, 228, 127, 150, 245, 31, 82, 201, 250, 49, 201, 72, 232, 149, 212, 156, 158, 247, 133, 172, 230, 109, 132, 119, 198, 148, 184, 146, 213, 179, 173, 149, 17, 28, 203, 123, 72, 180, 220, 159, 161, 117, 71, 61, 8, 150, 19, 212, 42, 25, 133, 216, 205, 8, 191, 107, 43, 198, 100 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 157, 36, 79, 129, 21, 225, 228, 127, 150, 245, 31, 82, 201, 250, 49, 201, 72, 232, 149, 212, 156, 158, 247, 133, 172, 230, 109, 132, 119, 198, 148, 184, 146, 213, 179, 173, 149, 17, 28, 203, 123, 72, 180, 220, 159, 161, 117, 71, 61, 8, 150, 19, 212, 42, 25, 133, 216, 205, 8, 191, 107, 43, 198, 100 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 155, 5, 184, 160, 50, 126, 28, 32, 187, 154, 24, 158, 194, 115, 53, 189, 236, 80, 121, 211, 4, 41, 175, 41, 172, 150, 113, 131, 147, 24, 24, 113, 86, 121, 129, 71, 51, 136, 242, 166, 148, 56, 60, 35, 42, 226, 240, 12, 180, 242, 227, 227, 127, 88, 123, 144, 53, 101, 119, 89, 25, 97, 10, 70 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9060));
        }
    }
}
