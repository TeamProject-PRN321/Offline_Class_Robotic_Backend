using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _331422 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e881fc4b-fa1c-4cc7-8529-a992de866986"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("de1b2005-9716-4fdb-939a-fabc31d35ce7"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8287), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 211, 202, 91, 169, 71, 231, 65, 61, 91, 95, 121, 54, 223, 55, 50, 0, 71, 116, 136, 8, 206, 119, 168, 39, 211, 58, 100, 0, 238, 238, 98, 45, 59, 192, 182, 123, 121, 157, 127, 81, 161, 125, 131, 204, 213, 131, 83, 132, 61, 189, 137, 163, 84, 173, 10, 150, 120, 109, 107, 228, 194, 118, 161, 204 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 211, 202, 91, 169, 71, 231, 65, 61, 91, 95, 121, 54, 223, 55, 50, 0, 71, 116, 136, 8, 206, 119, 168, 39, 211, 58, 100, 0, 238, 238, 98, 45, 59, 192, 182, 123, 121, 157, 127, 81, 161, 125, 131, 204, 213, 131, 83, 132, 61, 189, 137, 163, 84, 173, 10, 150, 120, 109, 107, 228, 194, 118, 161, 204 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 211, 202, 91, 169, 71, 231, 65, 61, 91, 95, 121, 54, 223, 55, 50, 0, 71, 116, 136, 8, 206, 119, 168, 39, 211, 58, 100, 0, 238, 238, 98, 45, 59, 192, 182, 123, 121, 157, 127, 81, 161, 125, 131, 204, 213, 131, 83, 132, 61, 189, 137, 163, 84, 173, 10, 150, 120, 109, 107, 228, 194, 118, 161, 204 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 10, 46, 29, 130, 52, 57, 252, 39, 9, 27, 99, 128, 146, 250, 15, 113, 40, 201, 177, 225, 245, 47, 38, 92, 251, 188, 88, 174, 34, 56, 70, 118, 28, 148, 106, 163, 196, 20, 252, 129, 244, 230, 196, 42, 171, 20, 98, 254, 248, 237, 202, 164, 6, 28, 118, 108, 204, 73, 234, 148, 45, 46, 138, 3 }, new byte[] { 150, 255, 46, 71, 147, 142, 121, 7, 158, 20, 248, 75, 251, 18, 180, 79, 196, 239, 37, 251, 245, 142, 205, 235, 142, 254, 48, 41, 28, 146, 94, 111, 2, 16, 46, 106, 56, 175, 231, 160, 232, 175, 244, 168, 29, 107, 127, 135, 13, 248, 65, 104, 233, 150, 254, 123, 249, 61, 223, 102, 216, 108, 73, 47, 206, 207, 165, 163, 72, 88, 137, 247, 24, 203, 48, 8, 228, 73, 170, 68, 5, 214, 84, 216, 155, 252, 101, 18, 131, 138, 46, 79, 85, 221, 194, 134, 107, 200, 215, 37, 147, 9, 154, 158, 75, 139, 40, 97, 251, 251, 165, 206, 85, 76, 85, 241, 19, 158, 155, 0, 46, 66, 173, 109, 59, 23, 183, 176 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 130, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 45, 129, DateTimeKind.Local).AddTicks(7154));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("de1b2005-9716-4fdb-939a-fabc31d35ce7"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("e881fc4b-fa1c-4cc7-8529-a992de866986"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4339), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 27, 135, 220, 189, 212, 218, 240, 34, 112, 188, 249, 145, 230, 109, 122, 210, 161, 136, 203, 169, 104, 0, 181, 236, 25, 137, 170, 78, 41, 207, 152, 136, 8, 29, 21, 129, 134, 169, 141, 205, 179, 115, 168, 49, 224, 249, 201, 140, 140, 165, 244, 127, 148, 122, 152, 104, 30, 107, 161, 50, 56, 218, 98 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 27, 135, 220, 189, 212, 218, 240, 34, 112, 188, 249, 145, 230, 109, 122, 210, 161, 136, 203, 169, 104, 0, 181, 236, 25, 137, 170, 78, 41, 207, 152, 136, 8, 29, 21, 129, 134, 169, 141, 205, 179, 115, 168, 49, 224, 249, 201, 140, 140, 165, 244, 127, 148, 122, 152, 104, 30, 107, 161, 50, 56, 218, 98 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 250, 27, 135, 220, 189, 212, 218, 240, 34, 112, 188, 249, 145, 230, 109, 122, 210, 161, 136, 203, 169, 104, 0, 181, 236, 25, 137, 170, 78, 41, 207, 152, 136, 8, 29, 21, 129, 134, 169, 141, 205, 179, 115, 168, 49, 224, 249, 201, 140, 140, 165, 244, 127, 148, 122, 152, 104, 30, 107, 161, 50, 56, 218, 98 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 245, 232, 160, 124, 94, 247, 66, 230, 75, 252, 82, 246, 245, 217, 210, 127, 44, 86, 191, 114, 203, 56, 42, 123, 25, 209, 197, 76, 161, 127, 161, 119, 52, 180, 219, 121, 28, 116, 40, 38, 52, 160, 236, 220, 101, 80, 70, 200, 32, 239, 171, 176, 39, 219, 64, 48, 218, 129, 222, 178, 103, 141, 104 }, new byte[] { 227, 94, 179, 221, 19, 218, 112, 229, 85, 116, 106, 254, 220, 209, 166, 113, 185, 171, 154, 198, 1, 36, 209, 225, 208, 179, 79, 218, 45, 1, 49, 141, 234, 114, 209, 235, 124, 198, 20, 193, 52, 173, 6, 124, 230, 54, 5, 244, 15, 77, 246, 7, 222, 238, 27, 29, 11, 187, 174, 27, 109, 203, 66, 130, 145, 22, 90, 251, 91, 230, 21, 221, 53, 122, 150, 94, 197, 222, 102, 102, 132, 139, 238, 79, 231, 101, 106, 124, 92, 188, 175, 75, 26, 221, 226, 122, 76, 90, 131, 5, 162, 183, 1, 190, 214, 130, 88, 93, 112, 196, 31, 198, 8, 237, 159, 78, 155, 143, 9, 123, 87, 125, 174, 57, 125, 184, 220, 165 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 79, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 28, 78, DateTimeKind.Local).AddTicks(2444));
        }
    }
}
