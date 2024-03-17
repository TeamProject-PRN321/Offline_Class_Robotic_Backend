using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class More : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("03a11913-f7e2-481b-bf27-e297ae165380"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("8269f1bf-9e48-461c-bbb2-633656c70c62"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8246), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 24, 238, 237, 29, 244, 52, 175, 160, 206, 97, 172, 210, 246, 60, 72, 215, 38, 59, 186, 219, 151, 211, 217, 31, 81, 42, 159, 60, 212, 249, 234, 4, 112, 53, 77, 137, 208, 5, 134, 221, 65, 96, 55, 195, 178, 221, 36, 88, 144, 179, 166, 140, 223, 47, 160, 8, 165, 181, 157, 43, 182, 220, 45, 158 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 24, 238, 237, 29, 244, 52, 175, 160, 206, 97, 172, 210, 246, 60, 72, 215, 38, 59, 186, 219, 151, 211, 217, 31, 81, 42, 159, 60, 212, 249, 234, 4, 112, 53, 77, 137, 208, 5, 134, 221, 65, 96, 55, 195, 178, 221, 36, 88, 144, 179, 166, 140, 223, 47, 160, 8, 165, 181, 157, 43, 182, 220, 45, 158 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 24, 238, 237, 29, 244, 52, 175, 160, 206, 97, 172, 210, 246, 60, 72, 215, 38, 59, 186, 219, 151, 211, 217, 31, 81, 42, 159, 60, 212, 249, 234, 4, 112, 53, 77, 137, 208, 5, 134, 221, 65, 96, 55, 195, 178, 221, 36, 88, 144, 179, 166, 140, 223, 47, 160, 8, 165, 181, 157, 43, 182, 220, 45, 158 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 240, 174, 141, 21, 193, 170, 223, 255, 116, 43, 173, 26, 108, 57, 20, 64, 193, 72, 13, 157, 5, 83, 181, 84, 187, 152, 68, 201, 126, 244, 130, 131, 8, 144, 63, 238, 43, 72, 21, 102, 22, 228, 38, 217, 8, 80, 201, 9, 156, 151, 243, 242, 196, 120, 114, 19, 162, 55, 80, 71, 94, 242, 116, 7 }, new byte[] { 187, 108, 168, 98, 182, 217, 208, 56, 55, 91, 158, 148, 136, 170, 251, 213, 99, 22, 20, 151, 221, 27, 220, 19, 24, 198, 158, 103, 184, 86, 196, 70, 193, 140, 244, 204, 47, 40, 88, 179, 104, 17, 11, 168, 186, 137, 26, 42, 36, 80, 185, 39, 244, 218, 23, 106, 243, 64, 118, 43, 239, 56, 94, 131, 227, 99, 20, 31, 82, 64, 99, 164, 116, 208, 214, 229, 97, 24, 2, 29, 88, 34, 111, 194, 67, 88, 175, 50, 107, 11, 127, 181, 156, 67, 71, 252, 14, 198, 238, 11, 20, 239, 96, 132, 155, 3, 158, 139, 61, 194, 148, 89, 141, 163, 116, 76, 18, 218, 85, 229, 104, 93, 164, 119, 119, 38, 33, 248 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 11, 20, 990, DateTimeKind.Local).AddTicks(7451), new DateTime(2024, 3, 12, 14, 11, 20, 990, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "ClassRoomId", "CreateBy", "Created", "Description", "DeviceName", "IsDeleted", "LastModified", "LastModifiedBy", "PriceOfDevice", "StatusOfDevice" },
                values: new object[] { new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"), new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"), null, new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8639), "Quạt trần", "Quạt", false, null, null, 200000.0, 3 });

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 990, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 990, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 990, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 991, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 11, 20, 990, DateTimeKind.Local).AddTicks(7484));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("8269f1bf-9e48-461c-bbb2-633656c70c62"));

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("03a11913-f7e2-481b-bf27-e297ae165380"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5396), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 172, 40, 120, 38, 140, 246, 30, 100, 140, 121, 207, 236, 54, 188, 218, 137, 53, 72, 79, 186, 6, 151, 6, 139, 133, 179, 217, 250, 172, 163, 91, 17, 208, 255, 242, 222, 120, 49, 162, 103, 255, 233, 42, 241, 96, 160, 14, 94, 243, 148, 185, 120, 65, 242, 219, 147, 24, 250, 100, 233, 208, 19, 215, 72 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 172, 40, 120, 38, 140, 246, 30, 100, 140, 121, 207, 236, 54, 188, 218, 137, 53, 72, 79, 186, 6, 151, 6, 139, 133, 179, 217, 250, 172, 163, 91, 17, 208, 255, 242, 222, 120, 49, 162, 103, 255, 233, 42, 241, 96, 160, 14, 94, 243, 148, 185, 120, 65, 242, 219, 147, 24, 250, 100, 233, 208, 19, 215, 72 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 172, 40, 120, 38, 140, 246, 30, 100, 140, 121, 207, 236, 54, 188, 218, 137, 53, 72, 79, 186, 6, 151, 6, 139, 133, 179, 217, 250, 172, 163, 91, 17, 208, 255, 242, 222, 120, 49, 162, 103, 255, 233, 42, 241, 96, 160, 14, 94, 243, 148, 185, 120, 65, 242, 219, 147, 24, 250, 100, 233, 208, 19, 215, 72 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 139, 28, 50, 254, 64, 96, 218, 155, 3, 86, 56, 15, 96, 5, 106, 168, 243, 62, 3, 1, 253, 129, 254, 60, 68, 25, 143, 26, 2, 45, 185, 45, 202, 225, 42, 20, 225, 255, 131, 67, 93, 64, 130, 57, 50, 202, 194, 1, 41, 239, 253, 204, 136, 20, 89, 85, 177, 11, 116, 112, 221, 133, 111, 189 }, new byte[] { 143, 179, 18, 34, 53, 131, 26, 40, 135, 210, 249, 233, 226, 57, 178, 199, 11, 213, 94, 255, 233, 123, 191, 197, 14, 169, 139, 146, 166, 95, 42, 51, 37, 151, 134, 94, 89, 135, 131, 179, 100, 42, 82, 108, 71, 210, 10, 91, 108, 181, 24, 197, 214, 236, 122, 36, 74, 134, 131, 236, 76, 75, 220, 112, 99, 135, 11, 177, 7, 118, 238, 85, 209, 32, 123, 146, 94, 184, 171, 12, 150, 243, 116, 214, 129, 169, 65, 135, 221, 105, 189, 97, 121, 158, 152, 104, 56, 123, 39, 144, 232, 172, 58, 6, 166, 103, 234, 159, 91, 64, 158, 6, 201, 180, 191, 141, 118, 4, 67, 224, 136, 159, 150, 59, 99, 194, 103, 226 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 8, 11, 434, DateTimeKind.Local).AddTicks(2397), new DateTime(2024, 3, 12, 14, 8, 11, 434, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 434, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 434, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 434, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 8, 11, 434, DateTimeKind.Local).AddTicks(2446));
        }
    }
}
