using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _1243 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("de15916c-a1c3-4c8a-a7ac-d78aa0dd35a0"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("a252aba7-0d73-4376-8176-f7a87e65c832"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5762), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 222, 201, 58, 45, 48, 70, 96, 150, 232, 178, 162, 142, 17, 192, 123, 116, 77, 88, 15, 12, 222, 200, 26, 172, 123, 19, 86, 213, 226, 95, 104, 141, 88, 86, 99, 38, 131, 23, 253, 163, 52, 92, 148, 63, 178, 106, 86, 52, 145, 80, 50, 227, 160, 114, 124, 159, 180, 224, 234, 78, 44, 1, 147, 243 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 222, 201, 58, 45, 48, 70, 96, 150, 232, 178, 162, 142, 17, 192, 123, 116, 77, 88, 15, 12, 222, 200, 26, 172, 123, 19, 86, 213, 226, 95, 104, 141, 88, 86, 99, 38, 131, 23, 253, 163, 52, 92, 148, 63, 178, 106, 86, 52, 145, 80, 50, 227, 160, 114, 124, 159, 180, 224, 234, 78, 44, 1, 147, 243 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 222, 201, 58, 45, 48, 70, 96, 150, 232, 178, 162, 142, 17, 192, 123, 116, 77, 88, 15, 12, 222, 200, 26, 172, 123, 19, 86, 213, 226, 95, 104, 141, 88, 86, 99, 38, 131, 23, 253, 163, 52, 92, 148, 63, 178, 106, 86, 52, 145, 80, 50, 227, 160, 114, 124, 159, 180, 224, 234, 78, 44, 1, 147, 243 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 103, 76, 104, 33, 41, 40, 132, 103, 16, 18, 248, 35, 200, 7, 141, 141, 200, 218, 105, 101, 190, 255, 201, 95, 167, 20, 232, 103, 134, 104, 177, 133, 33, 227, 183, 138, 84, 59, 151, 142, 235, 169, 108, 114, 211, 191, 129, 251, 160, 17, 219, 53, 229, 80, 234, 175, 150, 229, 212, 19, 104, 131, 238, 46 }, new byte[] { 157, 198, 153, 66, 16, 47, 128, 115, 36, 115, 89, 38, 162, 99, 198, 233, 111, 140, 215, 112, 220, 142, 76, 94, 219, 188, 125, 247, 231, 40, 163, 33, 190, 178, 155, 81, 84, 251, 169, 19, 109, 46, 161, 163, 29, 238, 61, 100, 92, 93, 152, 157, 123, 202, 2, 117, 230, 206, 117, 163, 196, 228, 87, 37, 44, 241, 230, 252, 207, 146, 89, 144, 28, 93, 160, 22, 11, 164, 183, 253, 214, 162, 190, 101, 37, 184, 203, 156, 70, 2, 167, 229, 188, 63, 42, 143, 140, 166, 134, 179, 151, 14, 73, 135, 114, 114, 90, 237, 20, 3, 225, 231, 129, 125, 37, 71, 131, 46, 174, 171, 46, 86, 3, 2, 230, 15, 232, 14 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 450, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 11, 449, DateTimeKind.Local).AddTicks(7499));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a252aba7-0d73-4376-8176-f7a87e65c832"));

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
    }
}
