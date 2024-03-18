using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _3314 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("bd6a03b8-2aaa-438f-94ed-8aa9b9ca40f1"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("e54388cb-f0d2-4871-a5e6-e06d052b27ce"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(564), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 142, 247, 11, 179, 81, 207, 80, 120, 48, 46, 71, 143, 191, 111, 26, 126, 135, 34, 202, 247, 108, 241, 67, 169, 147, 137, 155, 114, 176, 134, 32, 102, 106, 227, 110, 120, 201, 22, 62, 187, 108, 121, 135, 148, 249, 35, 182, 124, 234, 126, 133, 228, 255, 169, 29, 113, 113, 181, 61, 187, 29, 179, 170 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 142, 247, 11, 179, 81, 207, 80, 120, 48, 46, 71, 143, 191, 111, 26, 126, 135, 34, 202, 247, 108, 241, 67, 169, 147, 137, 155, 114, 176, 134, 32, 102, 106, 227, 110, 120, 201, 22, 62, 187, 108, 121, 135, 148, 249, 35, 182, 124, 234, 126, 133, 228, 255, 169, 29, 113, 113, 181, 61, 187, 29, 179, 170 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 142, 247, 11, 179, 81, 207, 80, 120, 48, 46, 71, 143, 191, 111, 26, 126, 135, 34, 202, 247, 108, 241, 67, 169, 147, 137, 155, 114, 176, 134, 32, 102, 106, 227, 110, 120, 201, 22, 62, 187, 108, 121, 135, 148, 249, 35, 182, 124, 234, 126, 133, 228, 255, 169, 29, 113, 113, 181, 61, 187, 29, 179, 170 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 215, 46, 206, 37, 208, 57, 213, 146, 222, 170, 179, 126, 192, 206, 168, 56, 142, 241, 20, 248, 73, 71, 223, 165, 192, 221, 136, 94, 83, 109, 61, 85, 76, 140, 62, 117, 71, 72, 100, 3, 208, 29, 94, 207, 249, 198, 65, 237, 187, 66, 246, 54, 62, 127, 66, 47, 194, 210, 25, 102, 191, 4, 47, 200 }, new byte[] { 203, 60, 56, 206, 2, 199, 114, 59, 44, 17, 98, 142, 99, 229, 154, 106, 236, 135, 233, 161, 250, 196, 252, 235, 171, 74, 29, 113, 18, 20, 37, 39, 135, 207, 140, 66, 231, 135, 240, 188, 46, 132, 64, 129, 180, 57, 26, 81, 97, 251, 225, 167, 94, 200, 27, 125, 185, 180, 207, 113, 209, 175, 46, 109, 79, 54, 247, 155, 181, 174, 58, 42, 76, 48, 176, 127, 27, 191, 193, 97, 130, 241, 204, 220, 85, 4, 123, 55, 198, 7, 213, 165, 0, 115, 92, 47, 102, 22, 241, 166, 181, 44, 235, 55, 104, 67, 19, 77, 162, 14, 210, 218, 192, 177, 137, 59, 81, 95, 245, 213, 172, 148, 205, 113, 75, 88, 193, 25 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 43, 16, 778, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 3, 19, 1, 43, 16, 778, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 778, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 778, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 777, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 777, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 778, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 779, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 16, 778, DateTimeKind.Local).AddTicks(442));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e54388cb-f0d2-4871-a5e6-e06d052b27ce"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("bd6a03b8-2aaa-438f-94ed-8aa9b9ca40f1"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2035), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 122, 161, 148, 104, 157, 143, 57, 203, 251, 192, 132, 195, 43, 231, 160, 184, 112, 4, 101, 184, 157, 187, 150, 152, 68, 122, 190, 19, 3, 153, 75, 187, 109, 69, 2, 31, 157, 16, 56, 89, 204, 253, 109, 149, 32, 175, 162, 221, 124, 166, 209, 163, 248, 240, 126, 187, 180, 137, 190, 233, 129, 246, 248 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 122, 161, 148, 104, 157, 143, 57, 203, 251, 192, 132, 195, 43, 231, 160, 184, 112, 4, 101, 184, 157, 187, 150, 152, 68, 122, 190, 19, 3, 153, 75, 187, 109, 69, 2, 31, 157, 16, 56, 89, 204, 253, 109, 149, 32, 175, 162, 221, 124, 166, 209, 163, 248, 240, 126, 187, 180, 137, 190, 233, 129, 246, 248 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 122, 161, 148, 104, 157, 143, 57, 203, 251, 192, 132, 195, 43, 231, 160, 184, 112, 4, 101, 184, 157, 187, 150, 152, 68, 122, 190, 19, 3, 153, 75, 187, 109, 69, 2, 31, 157, 16, 56, 89, 204, 253, 109, 149, 32, 175, 162, 221, 124, 166, 209, 163, 248, 240, 126, 187, 180, 137, 190, 233, 129, 246, 248 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 136, 101, 213, 41, 97, 81, 30, 247, 225, 137, 26, 253, 194, 118, 48, 69, 197, 220, 9, 127, 149, 224, 27, 196, 43, 194, 86, 78, 96, 123, 107, 16, 69, 51, 49, 58, 180, 99, 7, 195, 40, 37, 16, 140, 76, 142, 119, 14, 152, 100, 122, 228, 157, 88, 249, 235, 84, 68, 19, 251, 189, 172, 246, 2 }, new byte[] { 168, 117, 59, 104, 49, 213, 9, 146, 164, 69, 134, 122, 89, 242, 1, 141, 124, 5, 55, 54, 150, 69, 1, 17, 213, 12, 44, 182, 139, 164, 71, 103, 26, 104, 36, 226, 145, 145, 225, 157, 135, 112, 147, 85, 197, 251, 18, 105, 19, 102, 140, 88, 225, 148, 49, 160, 66, 17, 115, 33, 109, 215, 134, 124, 217, 181, 102, 89, 46, 174, 100, 125, 99, 83, 210, 254, 222, 33, 99, 231, 248, 71, 226, 71, 50, 106, 221, 0, 189, 70, 149, 238, 133, 152, 101, 78, 40, 52, 10, 69, 67, 146, 214, 247, 108, 153, 73, 182, 158, 212, 106, 4, 228, 214, 76, 39, 129, 68, 19, 135, 138, 34, 204, 163, 154, 123, 236, 204 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1554), new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 292, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 9, 291, DateTimeKind.Local).AddTicks(1584));
        }
    }
}
