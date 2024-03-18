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
                keyValue: new Guid("abec8fb6-e893-41de-9676-c6c86c0117f0"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("36fba5a5-e6ae-49a8-bca0-101c1506015e"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7433), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 25, 226, 211, 217, 11, 14, 158, 213, 241, 204, 216, 145, 232, 22, 255, 137, 239, 27, 202, 181, 234, 31, 126, 33, 163, 90, 157, 121, 89, 155, 110, 56, 42, 127, 135, 103, 161, 117, 110, 179, 5, 173, 140, 80, 216, 171, 70, 245, 178, 222, 14, 202, 136, 134, 179, 135, 121, 126, 149, 56, 134, 45, 112, 30 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 25, 226, 211, 217, 11, 14, 158, 213, 241, 204, 216, 145, 232, 22, 255, 137, 239, 27, 202, 181, 234, 31, 126, 33, 163, 90, 157, 121, 89, 155, 110, 56, 42, 127, 135, 103, 161, 117, 110, 179, 5, 173, 140, 80, 216, 171, 70, 245, 178, 222, 14, 202, 136, 134, 179, 135, 121, 126, 149, 56, 134, 45, 112, 30 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 25, 226, 211, 217, 11, 14, 158, 213, 241, 204, 216, 145, 232, 22, 255, 137, 239, 27, 202, 181, 234, 31, 126, 33, 163, 90, 157, 121, 89, 155, 110, 56, 42, 127, 135, 103, 161, 117, 110, 179, 5, 173, 140, 80, 216, 171, 70, 245, 178, 222, 14, 202, 136, 134, 179, 135, 121, 126, 149, 56, 134, 45, 112, 30 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 81, 13, 38, 171, 229, 111, 215, 34, 217, 64, 167, 182, 241, 224, 159, 75, 3, 95, 112, 160, 116, 81, 99, 134, 47, 54, 191, 16, 111, 103, 173, 191, 228, 74, 87, 70, 223, 32, 68, 54, 100, 174, 1, 61, 37, 165, 106, 129, 137, 69, 103, 39, 216, 174, 118, 88, 92, 139, 79, 170, 240, 241, 171, 159 }, new byte[] { 131, 224, 204, 22, 233, 252, 158, 44, 251, 102, 173, 252, 169, 231, 241, 254, 81, 40, 247, 192, 142, 193, 205, 56, 115, 102, 118, 67, 209, 70, 196, 5, 100, 63, 105, 16, 72, 115, 222, 28, 209, 70, 236, 180, 84, 190, 146, 29, 137, 97, 7, 227, 183, 189, 116, 181, 19, 188, 214, 73, 189, 180, 189, 52, 250, 111, 105, 174, 253, 161, 205, 70, 108, 21, 192, 109, 69, 124, 226, 215, 83, 153, 47, 5, 47, 63, 114, 175, 146, 105, 91, 67, 157, 26, 10, 163, 214, 255, 210, 55, 102, 60, 120, 200, 169, 111, 112, 38, 19, 126, 216, 122, 28, 164, 80, 95, 249, 233, 249, 105, 225, 172, 104, 73, 24, 28, 17, 139 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(2064), new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 92, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 51, 91, DateTimeKind.Local).AddTicks(2101));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("36fba5a5-e6ae-49a8-bca0-101c1506015e"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("abec8fb6-e893-41de-9676-c6c86c0117f0"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4495), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 174, 249, 231, 132, 162, 25, 221, 134, 226, 93, 62, 230, 0, 211, 62, 208, 66, 31, 66, 103, 157, 207, 255, 210, 56, 184, 0, 242, 105, 121, 252, 53, 52, 169, 12, 214, 90, 148, 200, 242, 26, 56, 76, 5, 58, 191, 162, 65, 5, 211, 231, 152, 156, 8, 43, 222, 183, 224, 17, 82, 51, 128, 198, 192 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 174, 249, 231, 132, 162, 25, 221, 134, 226, 93, 62, 230, 0, 211, 62, 208, 66, 31, 66, 103, 157, 207, 255, 210, 56, 184, 0, 242, 105, 121, 252, 53, 52, 169, 12, 214, 90, 148, 200, 242, 26, 56, 76, 5, 58, 191, 162, 65, 5, 211, 231, 152, 156, 8, 43, 222, 183, 224, 17, 82, 51, 128, 198, 192 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 174, 249, 231, 132, 162, 25, 221, 134, 226, 93, 62, 230, 0, 211, 62, 208, 66, 31, 66, 103, 157, 207, 255, 210, 56, 184, 0, 242, 105, 121, 252, 53, 52, 169, 12, 214, 90, 148, 200, 242, 26, 56, 76, 5, 58, 191, 162, 65, 5, 211, 231, 152, 156, 8, 43, 222, 183, 224, 17, 82, 51, 128, 198, 192 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 231, 252, 97, 209, 188, 119, 103, 244, 107, 50, 92, 216, 143, 54, 181, 251, 181, 44, 27, 127, 89, 22, 209, 44, 159, 199, 1, 119, 20, 121, 27, 220, 76, 154, 196, 217, 152, 147, 153, 187, 144, 106, 94, 173, 194, 53, 217, 220, 84, 138, 157, 122, 36, 215, 181, 193, 63, 168, 0, 138, 170, 140, 65, 223 }, new byte[] { 100, 28, 113, 80, 69, 100, 159, 85, 140, 180, 106, 27, 251, 5, 45, 222, 68, 235, 47, 142, 96, 30, 101, 220, 58, 7, 129, 101, 154, 150, 41, 91, 251, 22, 129, 124, 230, 180, 38, 82, 37, 192, 180, 10, 238, 118, 180, 60, 95, 249, 78, 73, 156, 229, 194, 225, 137, 46, 126, 20, 34, 220, 46, 27, 98, 19, 58, 198, 9, 77, 96, 27, 85, 43, 164, 204, 179, 91, 167, 69, 103, 159, 226, 117, 223, 238, 150, 237, 143, 89, 194, 104, 67, 101, 97, 3, 50, 166, 173, 187, 140, 202, 56, 39, 153, 82, 152, 244, 82, 15, 57, 252, 217, 128, 94, 110, 228, 54, 208, 230, 19, 138, 126, 181, 222, 169, 131, 96 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 32, 44, 709, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 3, 19, 1, 32, 44, 709, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 709, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 710, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 709, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 709, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 709, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 711, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 32, 44, 709, DateTimeKind.Local).AddTicks(9963));
        }
    }
}
