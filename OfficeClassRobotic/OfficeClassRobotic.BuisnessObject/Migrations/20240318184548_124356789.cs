using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _124356789 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("97f64b46-9550-411f-bcbc-5992e96fcc33"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("33a22bd9-b057-4a83-8af9-e38e7ebfad71"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6098), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 34, 12, 139, 139, 86, 20, 44, 0, 209, 59, 3, 250, 250, 224, 13, 159, 135, 0, 195, 218, 62, 14, 251, 243, 87, 230, 182, 192, 127, 219, 80, 143, 14, 138, 107, 157, 242, 146, 133, 118, 166, 41, 72, 29, 150, 175, 74, 163, 175, 111, 141, 103, 84, 117, 79, 163, 47, 143, 140, 145, 137, 8, 16, 255 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 34, 12, 139, 139, 86, 20, 44, 0, 209, 59, 3, 250, 250, 224, 13, 159, 135, 0, 195, 218, 62, 14, 251, 243, 87, 230, 182, 192, 127, 219, 80, 143, 14, 138, 107, 157, 242, 146, 133, 118, 166, 41, 72, 29, 150, 175, 74, 163, 175, 111, 141, 103, 84, 117, 79, 163, 47, 143, 140, 145, 137, 8, 16, 255 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 34, 12, 139, 139, 86, 20, 44, 0, 209, 59, 3, 250, 250, 224, 13, 159, 135, 0, 195, 218, 62, 14, 251, 243, 87, 230, 182, 192, 127, 219, 80, 143, 14, 138, 107, 157, 242, 146, 133, 118, 166, 41, 72, 29, 150, 175, 74, 163, 175, 111, 141, 103, 84, 117, 79, 163, 47, 143, 140, 145, 137, 8, 16, 255 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 58, 85, 74, 47, 1, 199, 111, 167, 19, 103, 60, 92, 87, 103, 16, 113, 130, 115, 3, 120, 57, 223, 179, 109, 127, 87, 42, 189, 67, 244, 33, 252, 122, 169, 248, 202, 189, 247, 14, 31, 4, 37, 167, 250, 68, 7, 26, 182, 171, 89, 68, 79, 54, 157, 227, 141, 23, 154, 159, 205, 80, 82, 129, 201 }, new byte[] { 170, 136, 126, 73, 159, 153, 212, 7, 15, 124, 23, 192, 29, 230, 151, 68, 190, 188, 86, 237, 75, 78, 25, 190, 175, 82, 133, 37, 229, 242, 167, 214, 204, 32, 100, 82, 20, 121, 49, 170, 117, 88, 16, 52, 114, 127, 143, 203, 167, 213, 22, 137, 230, 236, 182, 215, 105, 112, 77, 211, 21, 165, 29, 194, 45, 109, 138, 146, 93, 102, 167, 24, 103, 41, 180, 57, 160, 179, 232, 16, 8, 174, 116, 150, 190, 50, 50, 125, 74, 11, 63, 208, 90, 42, 72, 160, 165, 40, 192, 192, 144, 228, 218, 107, 58, 234, 53, 21, 196, 215, 251, 82, 214, 147, 14, 161, 185, 94, 155, 114, 164, 224, 135, 170, 29, 137, 207, 178 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 681, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 47, 680, DateTimeKind.Local).AddTicks(7572));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("33a22bd9-b057-4a83-8af9-e38e7ebfad71"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("97f64b46-9550-411f-bcbc-5992e96fcc33"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2040), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 249, 84, 58, 9, 172, 144, 239, 162, 63, 143, 128, 70, 218, 32, 30, 249, 56, 224, 128, 180, 123, 43, 41, 153, 143, 155, 255, 221, 184, 171, 221, 174, 14, 142, 109, 212, 174, 241, 226, 61, 96, 182, 196, 209, 75, 71, 149, 51, 47, 17, 110, 67, 179, 137, 105, 134, 72, 127, 125, 141, 42, 196, 70, 198 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 249, 84, 58, 9, 172, 144, 239, 162, 63, 143, 128, 70, 218, 32, 30, 249, 56, 224, 128, 180, 123, 43, 41, 153, 143, 155, 255, 221, 184, 171, 221, 174, 14, 142, 109, 212, 174, 241, 226, 61, 96, 182, 196, 209, 75, 71, 149, 51, 47, 17, 110, 67, 179, 137, 105, 134, 72, 127, 125, 141, 42, 196, 70, 198 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 249, 84, 58, 9, 172, 144, 239, 162, 63, 143, 128, 70, 218, 32, 30, 249, 56, 224, 128, 180, 123, 43, 41, 153, 143, 155, 255, 221, 184, 171, 221, 174, 14, 142, 109, 212, 174, 241, 226, 61, 96, 182, 196, 209, 75, 71, 149, 51, 47, 17, 110, 67, 179, 137, 105, 134, 72, 127, 125, 141, 42, 196, 70, 198 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 19, 132, 168, 12, 70, 106, 234, 146, 192, 97, 247, 174, 239, 44, 27, 41, 120, 185, 3, 165, 28, 87, 124, 77, 145, 207, 120, 56, 63, 125, 68, 196, 144, 217, 28, 180, 194, 36, 114, 35, 225, 135, 85, 20, 88, 100, 111, 10, 59, 126, 250, 76, 6, 76, 232, 9, 55, 231, 5, 167, 110, 170, 253, 125 }, new byte[] { 150, 178, 159, 219, 169, 151, 72, 170, 168, 25, 141, 222, 110, 170, 54, 89, 239, 39, 115, 22, 99, 165, 142, 92, 24, 174, 231, 202, 166, 180, 193, 127, 57, 151, 89, 170, 190, 180, 79, 15, 70, 90, 104, 71, 138, 224, 196, 195, 214, 87, 254, 43, 25, 57, 208, 107, 81, 65, 214, 100, 226, 106, 210, 111, 223, 6, 52, 29, 169, 238, 251, 43, 76, 140, 30, 246, 77, 39, 25, 50, 243, 114, 134, 130, 49, 19, 251, 52, 209, 237, 226, 130, 152, 110, 224, 146, 117, 225, 177, 185, 162, 2, 14, 181, 81, 9, 65, 43, 247, 198, 182, 135, 145, 44, 4, 182, 179, 70, 177, 221, 246, 59, 93, 111, 46, 14, 68, 94 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 16, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 45, 41, 15, DateTimeKind.Local).AddTicks(3828));
        }
    }
}
