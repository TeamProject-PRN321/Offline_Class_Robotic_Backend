using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _124356 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6c207af9-d586-460d-9758-5718467f7052"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("dc7cfc93-fa89-4218-8709-cfef98732d3c"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3021), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 247, 222, 105, 26, 210, 2, 249, 129, 5, 77, 197, 130, 172, 44, 175, 38, 68, 208, 47, 242, 31, 111, 139, 120, 136, 191, 232, 10, 44, 232, 171, 85, 238, 111, 223, 48, 189, 73, 9, 245, 60, 170, 102, 6, 186, 35, 71, 146, 34, 16, 102, 27, 165, 151, 165, 20, 73, 204, 119, 215, 109, 5, 126, 67 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 247, 222, 105, 26, 210, 2, 249, 129, 5, 77, 197, 130, 172, 44, 175, 38, 68, 208, 47, 242, 31, 111, 139, 120, 136, 191, 232, 10, 44, 232, 171, 85, 238, 111, 223, 48, 189, 73, 9, 245, 60, 170, 102, 6, 186, 35, 71, 146, 34, 16, 102, 27, 165, 151, 165, 20, 73, 204, 119, 215, 109, 5, 126, 67 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 247, 222, 105, 26, 210, 2, 249, 129, 5, 77, 197, 130, 172, 44, 175, 38, 68, 208, 47, 242, 31, 111, 139, 120, 136, 191, 232, 10, 44, 232, 171, 85, 238, 111, 223, 48, 189, 73, 9, 245, 60, 170, 102, 6, 186, 35, 71, 146, 34, 16, 102, 27, 165, 151, 165, 20, 73, 204, 119, 215, 109, 5, 126, 67 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 55, 69, 252, 57, 136, 169, 108, 128, 108, 152, 9, 74, 194, 162, 155, 238, 72, 47, 93, 251, 18, 217, 194, 239, 68, 41, 73, 181, 246, 162, 153, 33, 79, 80, 83, 39, 225, 61, 5, 133, 37, 236, 176, 110, 132, 35, 144, 60, 191, 95, 153, 168, 83, 59, 159, 171, 13, 231, 179, 174, 220, 253, 225, 82 }, new byte[] { 160, 198, 93, 112, 89, 48, 66, 243, 198, 247, 39, 66, 150, 183, 182, 38, 202, 8, 109, 244, 214, 3, 2, 105, 68, 245, 203, 126, 163, 48, 253, 58, 107, 111, 144, 224, 95, 165, 202, 218, 216, 115, 129, 192, 214, 168, 95, 209, 209, 161, 72, 156, 7, 38, 210, 28, 159, 91, 204, 116, 207, 226, 63, 190, 102, 127, 103, 97, 121, 85, 247, 201, 84, 145, 246, 4, 190, 78, 58, 179, 4, 33, 3, 38, 151, 134, 153, 161, 100, 101, 14, 151, 70, 224, 3, 58, 210, 134, 66, 90, 249, 149, 171, 110, 153, 73, 190, 145, 61, 192, 90, 250, 88, 27, 61, 78, 68, 126, 68, 187, 159, 87, 240, 208, 201, 56, 236, 168 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 378, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 24, 377, DateTimeKind.Local).AddTicks(4290));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("dc7cfc93-fa89-4218-8709-cfef98732d3c"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("6c207af9-d586-460d-9758-5718467f7052"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(379), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 80, 180, 223, 26, 199, 161, 126, 245, 47, 252, 37, 186, 102, 140, 6, 5, 171, 133, 235, 45, 36, 63, 170, 208, 98, 212, 221, 90, 23, 75, 104, 139, 20, 108, 248, 186, 41, 15, 90, 155, 91, 1, 157, 88, 207, 0, 128, 55, 114, 208, 37, 243, 139, 52, 142, 19, 164, 220, 228, 191, 40, 33, 75, 242 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 80, 180, 223, 26, 199, 161, 126, 245, 47, 252, 37, 186, 102, 140, 6, 5, 171, 133, 235, 45, 36, 63, 170, 208, 98, 212, 221, 90, 23, 75, 104, 139, 20, 108, 248, 186, 41, 15, 90, 155, 91, 1, 157, 88, 207, 0, 128, 55, 114, 208, 37, 243, 139, 52, 142, 19, 164, 220, 228, 191, 40, 33, 75, 242 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 80, 180, 223, 26, 199, 161, 126, 245, 47, 252, 37, 186, 102, 140, 6, 5, 171, 133, 235, 45, 36, 63, 170, 208, 98, 212, 221, 90, 23, 75, 104, 139, 20, 108, 248, 186, 41, 15, 90, 155, 91, 1, 157, 88, 207, 0, 128, 55, 114, 208, 37, 243, 139, 52, 142, 19, 164, 220, 228, 191, 40, 33, 75, 242 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 63, 127, 111, 108, 134, 254, 108, 86, 64, 179, 123, 148, 247, 190, 208, 1, 34, 208, 180, 34, 173, 140, 167, 211, 67, 159, 185, 161, 217, 254, 234, 192, 232, 123, 95, 229, 206, 180, 68, 148, 224, 115, 42, 140, 158, 241, 174, 58, 4, 234, 129, 67, 14, 147, 188, 80, 17, 153, 139, 67, 234, 138, 137, 18 }, new byte[] { 167, 204, 234, 221, 97, 237, 227, 133, 211, 180, 82, 100, 116, 166, 93, 141, 55, 246, 10, 80, 225, 247, 94, 147, 182, 4, 161, 77, 77, 172, 38, 13, 155, 72, 36, 100, 161, 241, 182, 193, 82, 35, 25, 157, 58, 122, 187, 66, 18, 238, 17, 20, 242, 97, 111, 193, 148, 25, 109, 215, 229, 124, 28, 70, 198, 183, 95, 42, 167, 55, 231, 20, 90, 226, 168, 73, 16, 85, 130, 135, 83, 97, 196, 58, 49, 210, 143, 172, 92, 98, 212, 118, 192, 47, 248, 193, 49, 118, 219, 158, 114, 113, 250, 163, 110, 15, 97, 253, 228, 67, 77, 203, 136, 107, 102, 87, 235, 125, 117, 222, 109, 105, 26, 91, 201, 110, 255, 41 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1665), new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 346, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 17, 345, DateTimeKind.Local).AddTicks(1704));
        }
    }
}
