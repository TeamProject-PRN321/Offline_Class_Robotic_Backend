using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("41413638-730f-4b59-9a27-e6502ea26990"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("97c0dcee-be03-4804-957f-bcb8849cee3f"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5643), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 147, 230, 88, 241, 136, 29, 87, 165, 80, 0, 235, 204, 39, 87, 116, 167, 153, 138, 7, 8, 215, 7, 198, 103, 48, 5, 128, 13, 58, 37, 49, 105, 102, 215, 24, 206, 7, 39, 76, 213, 232, 211, 8, 206, 24, 146, 209, 82, 136, 201, 128, 150, 105, 172, 54, 159, 221, 127, 232, 18, 182, 242, 192, 240 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 147, 230, 88, 241, 136, 29, 87, 165, 80, 0, 235, 204, 39, 87, 116, 167, 153, 138, 7, 8, 215, 7, 198, 103, 48, 5, 128, 13, 58, 37, 49, 105, 102, 215, 24, 206, 7, 39, 76, 213, 232, 211, 8, 206, 24, 146, 209, 82, 136, 201, 128, 150, 105, 172, 54, 159, 221, 127, 232, 18, 182, 242, 192, 240 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 147, 230, 88, 241, 136, 29, 87, 165, 80, 0, 235, 204, 39, 87, 116, 167, 153, 138, 7, 8, 215, 7, 198, 103, 48, 5, 128, 13, 58, 37, 49, 105, 102, 215, 24, 206, 7, 39, 76, 213, 232, 211, 8, 206, 24, 146, 209, 82, 136, 201, 128, 150, 105, 172, 54, 159, 221, 127, 232, 18, 182, 242, 192, 240 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 119, 51, 162, 7, 109, 123, 111, 50, 99, 146, 20, 148, 104, 87, 250, 99, 139, 107, 209, 132, 108, 144, 235, 248, 110, 98, 81, 77, 84, 201, 80, 27, 20, 93, 148, 213, 108, 216, 190, 246, 158, 185, 45, 241, 7, 87, 227, 222, 214, 229, 244, 240, 212, 63, 197, 127, 81, 166, 116, 180, 124, 245, 96 }, new byte[] { 89, 138, 228, 33, 42, 100, 36, 26, 17, 175, 254, 231, 170, 67, 1, 44, 175, 61, 39, 118, 116, 199, 70, 121, 97, 211, 80, 90, 234, 118, 174, 121, 165, 128, 103, 16, 104, 209, 192, 166, 156, 46, 112, 31, 181, 37, 73, 14, 83, 228, 28, 233, 100, 135, 179, 185, 4, 241, 210, 211, 59, 219, 71, 200, 80, 157, 43, 174, 39, 191, 144, 189, 40, 145, 240, 236, 96, 168, 229, 246, 124, 40, 2, 43, 21, 71, 81, 159, 172, 48, 188, 38, 8, 213, 111, 203, 57, 166, 67, 23, 219, 162, 30, 13, 242, 36, 152, 204, 188, 56, 84, 171, 185, 223, 195, 196, 5, 6, 49, 97, 21, 109, 20, 94, 143, 244, 149, 188 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 503, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 46, 502, DateTimeKind.Local).AddTicks(7571));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("97c0dcee-be03-4804-957f-bcb8849cee3f"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("41413638-730f-4b59-9a27-e6502ea26990"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7235), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 181, 86, 47, 233, 240, 33, 166, 223, 98, 240, 182, 115, 201, 145, 138, 7, 29, 7, 47, 148, 65, 228, 34, 22, 36, 8, 79, 41, 99, 188, 152, 25, 232, 250, 188, 210, 36, 146, 11, 143, 151, 164, 80, 169, 37, 111, 241, 247, 19, 58, 190, 181, 161, 26, 60, 22, 160, 111, 198, 123, 40, 162, 3, 234 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 181, 86, 47, 233, 240, 33, 166, 223, 98, 240, 182, 115, 201, 145, 138, 7, 29, 7, 47, 148, 65, 228, 34, 22, 36, 8, 79, 41, 99, 188, 152, 25, 232, 250, 188, 210, 36, 146, 11, 143, 151, 164, 80, 169, 37, 111, 241, 247, 19, 58, 190, 181, 161, 26, 60, 22, 160, 111, 198, 123, 40, 162, 3, 234 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 181, 86, 47, 233, 240, 33, 166, 223, 98, 240, 182, 115, 201, 145, 138, 7, 29, 7, 47, 148, 65, 228, 34, 22, 36, 8, 79, 41, 99, 188, 152, 25, 232, 250, 188, 210, 36, 146, 11, 143, 151, 164, 80, 169, 37, 111, 241, 247, 19, 58, 190, 181, 161, 26, 60, 22, 160, 111, 198, 123, 40, 162, 3, 234 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 34, 10, 118, 10, 218, 75, 52, 240, 155, 87, 189, 196, 5, 156, 138, 36, 246, 7, 79, 1, 233, 137, 127, 228, 53, 4, 94, 145, 121, 1, 134, 185, 26, 117, 248, 247, 46, 71, 128, 238, 242, 139, 140, 120, 199, 76, 142, 70, 150, 55, 23, 223, 139, 184, 199, 19, 185, 72, 184, 239, 21, 243, 232 }, new byte[] { 106, 67, 92, 225, 185, 40, 230, 79, 169, 149, 204, 147, 178, 16, 216, 218, 18, 11, 219, 168, 132, 70, 49, 75, 186, 27, 107, 49, 251, 152, 241, 185, 39, 25, 185, 111, 38, 50, 163, 248, 29, 47, 79, 198, 20, 66, 189, 68, 244, 166, 232, 15, 130, 181, 178, 184, 219, 51, 117, 68, 88, 135, 188, 118, 95, 39, 221, 213, 35, 123, 29, 30, 137, 188, 165, 181, 128, 75, 241, 149, 230, 132, 21, 111, 4, 171, 138, 48, 233, 29, 165, 81, 122, 24, 38, 159, 3, 223, 140, 26, 219, 4, 163, 146, 220, 123, 154, 222, 88, 145, 5, 153, 43, 233, 184, 104, 235, 26, 54, 144, 234, 97, 44, 86, 111, 158, 1, 52 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(8983), new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 359, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 24, 40, 358, DateTimeKind.Local).AddTicks(9017));
        }
    }
}
