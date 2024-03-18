using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _33142 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e54388cb-f0d2-4871-a5e6-e06d052b27ce"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e881fc4b-fa1c-4cc7-8529-a992de866986"));

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
    }
}
