using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7988c128-5720-40f7-9bc9-bdab17a32dc3"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("3f97e923-71c4-4d7f-a293-38be36d06331"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(147), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 191, 8, 113, 111, 114, 156, 184, 7, 172, 8, 15, 158, 17, 149, 186, 119, 160, 32, 209, 254, 232, 247, 247, 31, 7, 201, 127, 168, 233, 205, 139, 155, 244, 65, 104, 165, 45, 18, 146, 67, 52, 41, 91, 243, 236, 26, 200, 247, 5, 50, 11, 41, 166, 63, 248, 32, 72, 118, 184, 192, 252, 91, 94, 2 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 191, 8, 113, 111, 114, 156, 184, 7, 172, 8, 15, 158, 17, 149, 186, 119, 160, 32, 209, 254, 232, 247, 247, 31, 7, 201, 127, 168, 233, 205, 139, 155, 244, 65, 104, 165, 45, 18, 146, 67, 52, 41, 91, 243, 236, 26, 200, 247, 5, 50, 11, 41, 166, 63, 248, 32, 72, 118, 184, 192, 252, 91, 94, 2 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 191, 8, 113, 111, 114, 156, 184, 7, 172, 8, 15, 158, 17, 149, 186, 119, 160, 32, 209, 254, 232, 247, 247, 31, 7, 201, 127, 168, 233, 205, 139, 155, 244, 65, 104, 165, 45, 18, 146, 67, 52, 41, 91, 243, 236, 26, 200, 247, 5, 50, 11, 41, 166, 63, 248, 32, 72, 118, 184, 192, 252, 91, 94, 2 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 138, 216, 217, 14, 38, 82, 79, 144, 39, 91, 146, 212, 210, 98, 162, 236, 135, 234, 180, 76, 105, 53, 71, 2, 41, 234, 82, 38, 216, 206, 150, 77, 254, 35, 189, 45, 147, 52, 17, 144, 154, 227, 208, 118, 77, 110, 168, 19, 72, 253, 25, 187, 167, 21, 159, 60, 56, 249, 179, 21, 248, 148, 207, 98 }, new byte[] { 90, 199, 180, 119, 163, 38, 125, 48, 39, 107, 101, 138, 26, 199, 113, 120, 135, 233, 245, 2, 60, 128, 253, 175, 216, 250, 81, 47, 66, 214, 217, 161, 119, 71, 12, 218, 122, 245, 220, 16, 23, 228, 62, 223, 3, 54, 170, 192, 153, 224, 74, 241, 120, 105, 90, 241, 97, 111, 226, 38, 100, 245, 67, 26, 51, 81, 152, 254, 202, 235, 17, 89, 218, 224, 246, 252, 247, 159, 133, 99, 78, 75, 11, 143, 53, 1, 254, 69, 21, 64, 52, 73, 93, 146, 240, 168, 14, 163, 114, 254, 253, 113, 94, 84, 74, 134, 168, 116, 169, 8, 19, 44, 102, 12, 242, 132, 247, 130, 98, 164, 162, 100, 234, 217, 165, 116, 55, 131 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(1941), new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 776, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 1, 50, 58, 775, DateTimeKind.Local).AddTicks(1967));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3f97e923-71c4-4d7f-a293-38be36d06331"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("7988c128-5720-40f7-9bc9-bdab17a32dc3"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7721), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 194, 166, 171, 165, 212, 153, 196, 102, 235, 36, 81, 157, 180, 51, 121, 216, 185, 246, 82, 138, 228, 156, 125, 25, 54, 232, 251, 2, 51, 105, 170, 200, 21, 43, 43, 216, 217, 101, 24, 212, 156, 153, 116, 217, 118, 125, 7, 25, 46, 239, 20, 219, 50, 5, 50, 131, 222, 29, 123, 222, 222, 238, 29, 48 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 194, 166, 171, 165, 212, 153, 196, 102, 235, 36, 81, 157, 180, 51, 121, 216, 185, 246, 82, 138, 228, 156, 125, 25, 54, 232, 251, 2, 51, 105, 170, 200, 21, 43, 43, 216, 217, 101, 24, 212, 156, 153, 116, 217, 118, 125, 7, 25, 46, 239, 20, 219, 50, 5, 50, 131, 222, 29, 123, 222, 222, 238, 29, 48 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 194, 166, 171, 165, 212, 153, 196, 102, 235, 36, 81, 157, 180, 51, 121, 216, 185, 246, 82, 138, 228, 156, 125, 25, 54, 232, 251, 2, 51, 105, 170, 200, 21, 43, 43, 216, 217, 101, 24, 212, 156, 153, 116, 217, 118, 125, 7, 25, 46, 239, 20, 219, 50, 5, 50, 131, 222, 29, 123, 222, 222, 238, 29, 48 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 184, 53, 223, 108, 36, 218, 39, 79, 191, 9, 204, 149, 36, 29, 169, 236, 168, 170, 140, 47, 85, 12, 54, 74, 84, 239, 29, 194, 109, 126, 125, 239, 87, 249, 189, 62, 210, 252, 64, 217, 54, 246, 158, 211, 1, 55, 113, 111, 14, 213, 213, 185, 130, 13, 114, 156, 54, 28, 158, 24, 109, 62, 8 }, new byte[] { 64, 254, 80, 194, 73, 214, 231, 150, 195, 186, 123, 159, 197, 12, 154, 189, 212, 44, 48, 181, 194, 204, 121, 104, 158, 90, 25, 32, 63, 232, 178, 41, 92, 115, 87, 61, 48, 235, 188, 14, 7, 25, 135, 183, 162, 225, 174, 11, 86, 48, 21, 55, 123, 171, 58, 94, 246, 140, 188, 248, 19, 128, 124, 105, 63, 53, 6, 107, 184, 203, 145, 54, 218, 146, 174, 9, 59, 223, 191, 91, 149, 144, 161, 186, 144, 89, 66, 92, 25, 6, 213, 153, 124, 224, 56, 91, 31, 58, 185, 218, 161, 255, 178, 180, 63, 40, 105, 187, 92, 42, 13, 106, 176, 197, 22, 218, 245, 206, 137, 224, 227, 209, 191, 224, 69, 82, 249, 157 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 860, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 20, 0, 54, 11, 859, DateTimeKind.Local).AddTicks(7459));
        }
    }
}
