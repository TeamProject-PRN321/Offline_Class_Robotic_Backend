using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("96f7341e-5336-4c5d-a839-b135b681c8ea"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("6fa70fd3-c705-4b39-8bed-09a27d868f12"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(204), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 173, 202, 196, 163, 114, 111, 133, 107, 101, 112, 251, 85, 15, 83, 57, 185, 211, 227, 139, 220, 129, 105, 133, 160, 231, 85, 64, 29, 188, 241, 222, 236, 177, 182, 4, 88, 103, 209, 192, 170, 211, 191, 216, 194, 14, 116, 68, 7, 129, 147, 217, 144, 254, 253, 218, 255, 40, 39, 206, 121, 173, 95, 124, 252 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 173, 202, 196, 163, 114, 111, 133, 107, 101, 112, 251, 85, 15, 83, 57, 185, 211, 227, 139, 220, 129, 105, 133, 160, 231, 85, 64, 29, 188, 241, 222, 236, 177, 182, 4, 88, 103, 209, 192, 170, 211, 191, 216, 194, 14, 116, 68, 7, 129, 147, 217, 144, 254, 253, 218, 255, 40, 39, 206, 121, 173, 95, 124, 252 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 173, 202, 196, 163, 114, 111, 133, 107, 101, 112, 251, 85, 15, 83, 57, 185, 211, 227, 139, 220, 129, 105, 133, 160, 231, 85, 64, 29, 188, 241, 222, 236, 177, 182, 4, 88, 103, 209, 192, 170, 211, 191, 216, 194, 14, 116, 68, 7, 129, 147, 217, 144, 254, 253, 218, 255, 40, 39, 206, 121, 173, 95, 124, 252 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 235, 42, 204, 207, 211, 15, 154, 111, 151, 60, 4, 70, 63, 94, 190, 168, 209, 55, 167, 24, 78, 18, 139, 236, 213, 118, 21, 84, 216, 5, 197, 178, 41, 1, 26, 135, 193, 181, 66, 2, 70, 178, 70, 179, 25, 68, 58, 39, 208, 190, 250, 85, 204, 34, 163, 115, 164, 61, 6, 223, 185, 220, 215, 96 }, new byte[] { 155, 32, 250, 17, 154, 149, 172, 23, 182, 142, 214, 83, 234, 39, 28, 120, 48, 27, 199, 193, 127, 106, 117, 85, 153, 69, 135, 156, 105, 28, 255, 64, 131, 220, 34, 52, 45, 128, 57, 13, 202, 67, 117, 101, 255, 13, 236, 60, 27, 230, 0, 38, 93, 136, 33, 235, 99, 191, 134, 242, 22, 98, 53, 104, 111, 234, 143, 223, 209, 84, 82, 87, 145, 145, 114, 1, 142, 169, 157, 54, 41, 220, 48, 137, 1, 167, 3, 197, 59, 85, 116, 66, 190, 12, 71, 212, 223, 15, 181, 14, 73, 218, 155, 50, 19, 248, 248, 82, 185, 124, 82, 240, 234, 8, 149, 59, 154, 142, 121, 228, 1, 144, 123, 202, 2, 164, 106, 50 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 534, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 35, 533, DateTimeKind.Local).AddTicks(1823));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6fa70fd3-c705-4b39-8bed-09a27d868f12"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("96f7341e-5336-4c5d-a839-b135b681c8ea"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(7997), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 191, 219, 136, 93, 1, 28, 191, 134, 81, 213, 148, 102, 232, 30, 170, 46, 225, 41, 90, 197, 122, 41, 81, 78, 116, 251, 110, 56, 56, 158, 5, 107, 0, 133, 98, 9, 243, 74, 41, 197, 216, 111, 122, 143, 1, 28, 97, 136, 203, 32, 102, 111, 125, 185, 125, 8, 178, 127, 122, 126, 122, 77, 145 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 191, 219, 136, 93, 1, 28, 191, 134, 81, 213, 148, 102, 232, 30, 170, 46, 225, 41, 90, 197, 122, 41, 81, 78, 116, 251, 110, 56, 56, 158, 5, 107, 0, 133, 98, 9, 243, 74, 41, 197, 216, 111, 122, 143, 1, 28, 97, 136, 203, 32, 102, 111, 125, 185, 125, 8, 178, 127, 122, 126, 122, 77, 145 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 191, 219, 136, 93, 1, 28, 191, 134, 81, 213, 148, 102, 232, 30, 170, 46, 225, 41, 90, 197, 122, 41, 81, 78, 116, 251, 110, 56, 56, 158, 5, 107, 0, 133, 98, 9, 243, 74, 41, 197, 216, 111, 122, 143, 1, 28, 97, 136, 203, 32, 102, 111, 125, 185, 125, 8, 178, 127, 122, 126, 122, 77, 145 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 252, 116, 169, 242, 122, 124, 121, 39, 49, 216, 107, 196, 179, 201, 9, 146, 224, 196, 102, 47, 63, 54, 96, 218, 220, 113, 9, 74, 57, 206, 115, 104, 168, 77, 111, 89, 103, 247, 0, 75, 124, 171, 39, 246, 188, 42, 235, 91, 64, 187, 218, 9, 146, 0, 53, 54, 180, 170, 88, 222, 137, 136, 164, 247 }, new byte[] { 126, 133, 235, 23, 38, 251, 215, 102, 108, 198, 100, 37, 107, 187, 90, 134, 159, 206, 165, 133, 44, 52, 87, 22, 240, 29, 37, 94, 128, 135, 180, 97, 220, 46, 194, 58, 107, 116, 96, 50, 25, 251, 48, 175, 88, 153, 246, 12, 23, 43, 20, 204, 192, 105, 192, 7, 68, 220, 89, 222, 228, 7, 74, 13, 62, 94, 181, 8, 16, 196, 251, 95, 145, 34, 141, 178, 63, 129, 208, 146, 18, 215, 63, 165, 234, 31, 199, 144, 51, 120, 74, 61, 141, 220, 228, 159, 68, 45, 147, 98, 101, 81, 22, 227, 173, 239, 79, 98, 121, 218, 245, 169, 137, 219, 198, 174, 81, 223, 135, 121, 179, 130, 42, 151, 252, 118, 158, 65 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(9058), new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 561, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 29, 560, DateTimeKind.Local).AddTicks(9229));
        }
    }
}
