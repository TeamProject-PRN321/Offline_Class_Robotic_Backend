using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _12345436 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a43604a2-2933-4184-b12b-994926949c01"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("bc4ba5c6-458a-4aeb-be38-d7d0ceb7edd0"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7077), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 46, 197, 182, 109, 141, 221, 228, 201, 149, 229, 241, 133, 159, 243, 197, 214, 45, 214, 173, 30, 216, 244, 103, 10, 212, 180, 96, 86, 227, 97, 6, 214, 180, 157, 204, 182, 38, 30, 137, 34, 221, 30, 235, 223, 79, 93, 19, 57, 242, 168, 139, 50, 17, 180, 150, 8, 120, 236, 115, 175, 168, 191, 28, 99 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 46, 197, 182, 109, 141, 221, 228, 201, 149, 229, 241, 133, 159, 243, 197, 214, 45, 214, 173, 30, 216, 244, 103, 10, 212, 180, 96, 86, 227, 97, 6, 214, 180, 157, 204, 182, 38, 30, 137, 34, 221, 30, 235, 223, 79, 93, 19, 57, 242, 168, 139, 50, 17, 180, 150, 8, 120, 236, 115, 175, 168, 191, 28, 99 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 46, 197, 182, 109, 141, 221, 228, 201, 149, 229, 241, 133, 159, 243, 197, 214, 45, 214, 173, 30, 216, 244, 103, 10, 212, 180, 96, 86, 227, 97, 6, 214, 180, 157, 204, 182, 38, 30, 137, 34, 221, 30, 235, 223, 79, 93, 19, 57, 242, 168, 139, 50, 17, 180, 150, 8, 120, 236, 115, 175, 168, 191, 28, 99 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 83, 124, 86, 27, 84, 224, 8, 115, 15, 234, 230, 7, 190, 197, 128, 168, 252, 195, 94, 131, 26, 46, 124, 108, 1, 190, 16, 171, 72, 136, 250, 164, 219, 216, 96, 206, 208, 104, 50, 119, 9, 134, 249, 35, 190, 100, 99, 17, 20, 248, 36, 52, 254, 139, 201, 70, 242, 199, 218, 110, 139, 251, 180 }, new byte[] { 110, 71, 253, 226, 119, 28, 69, 46, 79, 26, 109, 45, 118, 39, 79, 35, 212, 207, 139, 48, 96, 150, 30, 229, 209, 86, 152, 199, 173, 91, 9, 249, 60, 26, 55, 135, 67, 250, 251, 239, 12, 232, 78, 44, 186, 146, 90, 97, 42, 190, 245, 220, 4, 92, 11, 110, 87, 98, 189, 69, 40, 27, 97, 86, 121, 243, 5, 144, 226, 202, 140, 245, 151, 52, 156, 131, 152, 221, 13, 123, 211, 179, 238, 92, 53, 232, 34, 148, 82, 77, 5, 226, 122, 223, 68, 34, 84, 144, 110, 143, 69, 93, 86, 143, 121, 67, 230, 226, 178, 234, 19, 200, 111, 236, 26, 209, 25, 24, 174, 73, 4, 10, 160, 221, 88, 52, 240, 246 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1694), new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 624, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 15, 622, DateTimeKind.Local).AddTicks(1725));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("bc4ba5c6-458a-4aeb-be38-d7d0ceb7edd0"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("a43604a2-2933-4184-b12b-994926949c01"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9324), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 45, 133, 95, 39, 189, 6, 233, 197, 179, 201, 66, 14, 106, 178, 149, 57, 108, 214, 107, 42, 117, 132, 65, 223, 65, 205, 248, 21, 41, 49, 126, 240, 233, 237, 239, 197, 208, 225, 15, 199, 23, 130, 89, 75, 215, 191, 95, 27, 141, 149, 53, 74, 38, 255, 70, 156, 243, 174, 16, 65, 37, 115, 46, 75 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 45, 133, 95, 39, 189, 6, 233, 197, 179, 201, 66, 14, 106, 178, 149, 57, 108, 214, 107, 42, 117, 132, 65, 223, 65, 205, 248, 21, 41, 49, 126, 240, 233, 237, 239, 197, 208, 225, 15, 199, 23, 130, 89, 75, 215, 191, 95, 27, 141, 149, 53, 74, 38, 255, 70, 156, 243, 174, 16, 65, 37, 115, 46, 75 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 45, 133, 95, 39, 189, 6, 233, 197, 179, 201, 66, 14, 106, 178, 149, 57, 108, 214, 107, 42, 117, 132, 65, 223, 65, 205, 248, 21, 41, 49, 126, 240, 233, 237, 239, 197, 208, 225, 15, 199, 23, 130, 89, 75, 215, 191, 95, 27, 141, 149, 53, 74, 38, 255, 70, 156, 243, 174, 16, 65, 37, 115, 46, 75 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 99, 17, 152, 164, 107, 83, 239, 126, 136, 5, 88, 226, 200, 235, 181, 138, 176, 39, 85, 151, 171, 118, 59, 105, 45, 124, 157, 206, 120, 74, 22, 191, 226, 58, 143, 241, 85, 197, 84, 183, 86, 151, 29, 235, 167, 179, 205, 233, 31, 196, 60, 40, 222, 204, 118, 198, 210, 11, 39, 31, 227, 209, 229, 127 }, new byte[] { 204, 81, 218, 93, 52, 206, 60, 117, 158, 151, 222, 85, 230, 247, 167, 133, 49, 87, 86, 162, 204, 198, 59, 185, 44, 0, 47, 1, 95, 175, 0, 68, 16, 235, 84, 91, 128, 89, 78, 222, 143, 230, 245, 21, 71, 158, 82, 223, 174, 13, 191, 37, 42, 135, 135, 141, 217, 148, 140, 127, 169, 85, 122, 176, 130, 156, 225, 106, 125, 240, 87, 219, 80, 62, 97, 234, 144, 77, 170, 104, 184, 236, 187, 16, 172, 153, 162, 143, 191, 111, 84, 137, 22, 238, 68, 230, 253, 130, 141, 178, 35, 254, 127, 23, 222, 233, 244, 164, 12, 252, 255, 146, 152, 36, 132, 127, 139, 120, 37, 202, 142, 63, 137, 188, 198, 115, 233, 163 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 310, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 33, 8, 309, DateTimeKind.Local).AddTicks(8152));
        }
    }
}
