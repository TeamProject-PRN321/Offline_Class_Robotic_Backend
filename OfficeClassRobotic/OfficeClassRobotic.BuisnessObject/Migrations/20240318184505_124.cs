using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("016887f5-7be0-4bcc-9f3d-0085e8a620e2"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("de15916c-a1c3-4c8a-a7ac-d78aa0dd35a0"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2291), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 255, 137, 106, 107, 60, 209, 115, 136, 211, 255, 219, 125, 223, 234, 193, 99, 20, 124, 209, 218, 190, 131, 243, 230, 202, 63, 73, 193, 37, 7, 108, 48, 250, 39, 208, 152, 16, 119, 185, 108, 243, 63, 253, 177, 204, 209, 155, 48, 203, 60, 157, 25, 166, 52, 192, 253, 23, 48, 30, 222, 176, 84, 177, 176 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 255, 137, 106, 107, 60, 209, 115, 136, 211, 255, 219, 125, 223, 234, 193, 99, 20, 124, 209, 218, 190, 131, 243, 230, 202, 63, 73, 193, 37, 7, 108, 48, 250, 39, 208, 152, 16, 119, 185, 108, 243, 63, 253, 177, 204, 209, 155, 48, 203, 60, 157, 25, 166, 52, 192, 253, 23, 48, 30, 222, 176, 84, 177, 176 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 255, 137, 106, 107, 60, 209, 115, 136, 211, 255, 219, 125, 223, 234, 193, 99, 20, 124, 209, 218, 190, 131, 243, 230, 202, 63, 73, 193, 37, 7, 108, 48, 250, 39, 208, 152, 16, 119, 185, 108, 243, 63, 253, 177, 204, 209, 155, 48, 203, 60, 157, 25, 166, 52, 192, 253, 23, 48, 30, 222, 176, 84, 177, 176 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 0, 229, 98, 42, 133, 14, 211, 238, 71, 36, 75, 236, 43, 100, 230, 3, 250, 176, 174, 239, 47, 104, 200, 201, 254, 86, 171, 207, 80, 183, 5, 114, 93, 168, 10, 128, 110, 62, 127, 164, 62, 8, 63, 21, 210, 157, 2, 35, 46, 1, 116, 191, 178, 75, 117, 136, 189, 221, 209, 251, 105, 246, 79, 52 }, new byte[] { 193, 209, 65, 156, 72, 112, 147, 46, 91, 197, 13, 111, 123, 166, 122, 229, 110, 20, 15, 39, 32, 234, 161, 125, 21, 81, 71, 203, 196, 121, 11, 154, 136, 129, 190, 55, 237, 29, 235, 20, 135, 200, 184, 239, 161, 115, 206, 25, 93, 196, 2, 63, 68, 5, 19, 32, 207, 123, 35, 167, 232, 34, 185, 69, 229, 222, 108, 8, 219, 207, 3, 237, 155, 208, 25, 165, 217, 92, 64, 111, 72, 77, 79, 247, 160, 225, 144, 28, 64, 200, 34, 151, 76, 160, 124, 89, 176, 156, 234, 15, 8, 175, 212, 5, 207, 202, 10, 77, 79, 251, 218, 105, 47, 239, 226, 127, 15, 67, 219, 228, 183, 154, 46, 236, 255, 74, 188, 77 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(3972), new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 195, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 5, 194, DateTimeKind.Local).AddTicks(3998));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("de15916c-a1c3-4c8a-a7ac-d78aa0dd35a0"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("016887f5-7be0-4bcc-9f3d-0085e8a620e2"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2561), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 22, 213, 56, 75, 100, 125, 48, 82, 212, 205, 238, 227, 83, 58, 198, 166, 71, 77, 189, 30, 115, 131, 104, 11, 101, 181, 228, 68, 222, 44, 235, 58, 11, 130, 231, 210, 198, 108, 159, 25, 160, 105, 175, 175, 58, 236, 94, 57, 194, 241, 82, 179, 224, 149, 152, 124, 163, 92, 133, 65, 222, 158, 170 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 22, 213, 56, 75, 100, 125, 48, 82, 212, 205, 238, 227, 83, 58, 198, 166, 71, 77, 189, 30, 115, 131, 104, 11, 101, 181, 228, 68, 222, 44, 235, 58, 11, 130, 231, 210, 198, 108, 159, 25, 160, 105, 175, 175, 58, 236, 94, 57, 194, 241, 82, 179, 224, 149, 152, 124, 163, 92, 133, 65, 222, 158, 170 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 22, 213, 56, 75, 100, 125, 48, 82, 212, 205, 238, 227, 83, 58, 198, 166, 71, 77, 189, 30, 115, 131, 104, 11, 101, 181, 228, 68, 222, 44, 235, 58, 11, 130, 231, 210, 198, 108, 159, 25, 160, 105, 175, 175, 58, 236, 94, 57, 194, 241, 82, 179, 224, 149, 152, 124, 163, 92, 133, 65, 222, 158, 170 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 209, 56, 233, 191, 73, 198, 189, 30, 73, 144, 61, 219, 149, 11, 244, 198, 229, 55, 131, 95, 107, 176, 28, 130, 255, 129, 191, 172, 62, 235, 2, 159, 67, 202, 155, 164, 35, 112, 81, 72, 188, 9, 184, 153, 160, 213, 66, 246, 89, 128, 160, 31, 192, 100, 94, 242, 235, 161, 163, 72, 247, 179, 192, 167 }, new byte[] { 58, 254, 95, 201, 241, 223, 126, 187, 59, 26, 151, 186, 243, 114, 174, 141, 107, 134, 223, 42, 155, 215, 15, 97, 67, 90, 23, 143, 87, 189, 24, 192, 131, 56, 99, 159, 51, 224, 90, 229, 61, 145, 227, 123, 233, 210, 110, 48, 137, 58, 163, 184, 239, 77, 189, 199, 146, 251, 165, 152, 151, 15, 129, 55, 47, 12, 207, 179, 129, 206, 164, 136, 246, 148, 113, 173, 66, 253, 65, 31, 32, 168, 175, 64, 140, 146, 248, 221, 71, 57, 79, 166, 158, 197, 233, 127, 251, 157, 89, 243, 99, 254, 68, 4, 162, 56, 59, 241, 118, 126, 201, 168, 30, 185, 59, 143, 1, 76, 34, 159, 159, 195, 209, 221, 103, 84, 109, 241 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 499, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 44, 57, 498, DateTimeKind.Local).AddTicks(3579));
        }
    }
}
