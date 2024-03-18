using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _124678 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("414c70d5-15c5-454a-b430-1948226172fe"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("0e6cd2a4-c4fd-4c6e-aa7a-7200edce90e6"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2949), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 108, 149, 224, 211, 217, 102, 222, 58, 18, 234, 206, 81, 213, 70, 207, 87, 56, 178, 33, 232, 8, 9, 12, 38, 73, 212, 148, 177, 108, 225, 151, 227, 52, 53, 33, 217, 16, 205, 176, 3, 71, 146, 207, 240, 68, 125, 225, 192, 247, 122, 53, 152, 87, 97, 214, 81, 109, 224, 98, 134, 96, 143, 11 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 108, 149, 224, 211, 217, 102, 222, 58, 18, 234, 206, 81, 213, 70, 207, 87, 56, 178, 33, 232, 8, 9, 12, 38, 73, 212, 148, 177, 108, 225, 151, 227, 52, 53, 33, 217, 16, 205, 176, 3, 71, 146, 207, 240, 68, 125, 225, 192, 247, 122, 53, 152, 87, 97, 214, 81, 109, 224, 98, 134, 96, 143, 11 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 108, 149, 224, 211, 217, 102, 222, 58, 18, 234, 206, 81, 213, 70, 207, 87, 56, 178, 33, 232, 8, 9, 12, 38, 73, 212, 148, 177, 108, 225, 151, 227, 52, 53, 33, 217, 16, 205, 176, 3, 71, 146, 207, 240, 68, 125, 225, 192, 247, 122, 53, 152, 87, 97, 214, 81, 109, 224, 98, 134, 96, 143, 11 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3307), new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3336));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("0e6cd2a4-c4fd-4c6e-aa7a-7200edce90e6"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("414c70d5-15c5-454a-b430-1948226172fe"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9784), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 128, 203, 104, 180, 209, 103, 228, 234, 25, 146, 70, 238, 211, 243, 111, 171, 219, 170, 129, 89, 162, 101, 154, 250, 92, 44, 89, 240, 115, 47, 167, 225, 95, 53, 167, 236, 140, 175, 188, 29, 30, 199, 191, 93, 47, 144, 25, 119, 56, 239, 5, 168, 171, 122, 100, 44, 150, 80, 255, 58, 15, 241, 226, 21 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 128, 203, 104, 180, 209, 103, 228, 234, 25, 146, 70, 238, 211, 243, 111, 171, 219, 170, 129, 89, 162, 101, 154, 250, 92, 44, 89, 240, 115, 47, 167, 225, 95, 53, 167, 236, 140, 175, 188, 29, 30, 199, 191, 93, 47, 144, 25, 119, 56, 239, 5, 168, 171, 122, 100, 44, 150, 80, 255, 58, 15, 241, 226, 21 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 128, 203, 104, 180, 209, 103, 228, 234, 25, 146, 70, 238, 211, 243, 111, 171, 219, 170, 129, 89, 162, 101, 154, 250, 92, 44, 89, 240, 115, 47, 167, 225, 95, 53, 167, 236, 140, 175, 188, 29, 30, 199, 191, 93, 47, 144, 25, 119, 56, 239, 5, 168, 171, 122, 100, 44, 150, 80, 255, 58, 15, 241, 226, 21 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 59, 147, 82, 6, 77, 36, 200, 32, 101, 119, 97, 203, 119, 241, 191, 111, 180, 211, 71, 59, 103, 212, 74, 176, 143, 34, 133, 187, 42, 253, 103, 145, 57, 147, 241, 14, 214, 142, 41, 45, 173, 61, 221, 90, 175, 133, 244, 64, 69, 12, 232, 2, 185, 72, 49, 7, 225, 87, 64, 209, 128, 189, 2, 162 }, new byte[] { 212, 153, 150, 25, 251, 11, 102, 60, 246, 243, 117, 86, 194, 139, 9, 8, 70, 49, 213, 149, 61, 193, 132, 158, 128, 169, 113, 249, 164, 6, 181, 86, 240, 162, 12, 33, 68, 80, 11, 26, 167, 183, 168, 101, 2, 199, 44, 68, 78, 230, 128, 218, 45, 134, 85, 220, 248, 37, 239, 205, 161, 182, 75, 44, 151, 158, 130, 225, 168, 67, 215, 235, 125, 79, 77, 65, 237, 41, 134, 68, 147, 169, 241, 190, 129, 117, 184, 15, 13, 92, 191, 248, 19, 194, 234, 226, 247, 84, 227, 6, 6, 157, 158, 122, 229, 122, 84, 174, 58, 180, 107, 71, 51, 44, 2, 196, 195, 204, 155, 173, 186, 202, 227, 48, 119, 132, 245, 238 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 211, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 211, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 211, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 211, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 211, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 210, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 211, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 211, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 54, 209, DateTimeKind.Local).AddTicks(9517));
        }
    }
}
