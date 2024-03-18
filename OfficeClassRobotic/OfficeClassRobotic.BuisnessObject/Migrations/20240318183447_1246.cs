using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _1246 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ef567c76-e7e6-4cbf-b3da-2cef7efa8790"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("6fe709b0-d16c-4491-a7e8-4cb614668a1e"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(1789), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 80, 13, 250, 72, 46, 248, 167, 82, 148, 97, 7, 242, 244, 252, 29, 54, 216, 94, 140, 189, 96, 62, 41, 143, 145, 40, 65, 97, 61, 25, 71, 13, 124, 158, 53, 225, 7, 26, 180, 62, 140, 208, 112, 251, 40, 79, 229, 10, 225, 213, 228, 239, 186, 169, 101, 46, 1, 8, 155, 218, 17, 208, 53 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 80, 13, 250, 72, 46, 248, 167, 82, 148, 97, 7, 242, 244, 252, 29, 54, 216, 94, 140, 189, 96, 62, 41, 143, 145, 40, 65, 97, 61, 25, 71, 13, 124, 158, 53, 225, 7, 26, 180, 62, 140, 208, 112, 251, 40, 79, 229, 10, 225, 213, 228, 239, 186, 169, 101, 46, 1, 8, 155, 218, 17, 208, 53 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 21, 80, 13, 250, 72, 46, 248, 167, 82, 148, 97, 7, 242, 244, 252, 29, 54, 216, 94, 140, 189, 96, 62, 41, 143, 145, 40, 65, 97, 61, 25, 71, 13, 124, 158, 53, 225, 7, 26, 180, 62, 140, 208, 112, 251, 40, 79, 229, 10, 225, 213, 228, 239, 186, 169, 101, 46, 1, 8, 155, 218, 17, 208, 53 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 227, 60, 103, 84, 23, 171, 213, 15, 32, 130, 83, 70, 34, 56, 28, 148, 147, 86, 203, 82, 217, 227, 73, 54, 253, 155, 39, 92, 69, 240, 63, 150, 85, 88, 133, 25, 229, 187, 246, 47, 77, 182, 41, 224, 213, 41, 177, 0, 167, 116, 226, 186, 244, 114, 176, 71, 224, 91, 155, 237, 114, 128, 166 }, new byte[] { 154, 16, 120, 42, 107, 2, 90, 32, 87, 119, 202, 189, 212, 14, 243, 48, 49, 182, 204, 178, 110, 42, 122, 45, 242, 242, 69, 233, 3, 105, 80, 15, 30, 238, 215, 105, 127, 236, 18, 20, 133, 170, 184, 215, 56, 230, 116, 187, 29, 157, 119, 27, 20, 41, 12, 63, 62, 7, 161, 70, 1, 114, 36, 16, 126, 46, 228, 12, 209, 224, 50, 214, 1, 238, 184, 133, 14, 72, 222, 90, 178, 167, 68, 241, 131, 212, 62, 116, 139, 112, 45, 243, 218, 246, 151, 120, 19, 95, 252, 206, 61, 36, 57, 33, 186, 207, 123, 186, 21, 140, 120, 23, 120, 153, 251, 211, 135, 12, 246, 149, 219, 150, 122, 84, 65, 72, 153, 195 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 552, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 47, 550, DateTimeKind.Local).AddTicks(4890));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6fe709b0-d16c-4491-a7e8-4cb614668a1e"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("ef567c76-e7e6-4cbf-b3da-2cef7efa8790"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1697), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 60, 136, 50, 83, 45, 73, 202, 66, 174, 86, 83, 220, 231, 167, 202, 130, 171, 75, 78, 110, 192, 100, 51, 55, 24, 143, 27, 74, 96, 168, 131, 149, 177, 132, 226, 48, 213, 120, 141, 223, 112, 173, 245, 98, 180, 98, 165, 35, 73, 33, 73, 49, 230, 196, 26, 254, 59, 247, 96, 187, 28, 221, 174, 240 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 60, 136, 50, 83, 45, 73, 202, 66, 174, 86, 83, 220, 231, 167, 202, 130, 171, 75, 78, 110, 192, 100, 51, 55, 24, 143, 27, 74, 96, 168, 131, 149, 177, 132, 226, 48, 213, 120, 141, 223, 112, 173, 245, 98, 180, 98, 165, 35, 73, 33, 73, 49, 230, 196, 26, 254, 59, 247, 96, 187, 28, 221, 174, 240 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 60, 136, 50, 83, 45, 73, 202, 66, 174, 86, 83, 220, 231, 167, 202, 130, 171, 75, 78, 110, 192, 100, 51, 55, 24, 143, 27, 74, 96, 168, 131, 149, 177, 132, 226, 48, 213, 120, 141, 223, 112, 173, 245, 98, 180, 98, 165, 35, 73, 33, 73, 49, 230, 196, 26, 254, 59, 247, 96, 187, 28, 221, 174, 240 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 101, 33, 58, 228, 56, 140, 24, 66, 0, 147, 235, 146, 183, 43, 176, 114, 101, 203, 169, 114, 238, 231, 15, 70, 31, 186, 75, 163, 223, 189, 180, 43, 99, 194, 97, 117, 166, 163, 44, 214, 76, 137, 67, 5, 136, 89, 179, 231, 254, 243, 181, 80, 132, 210, 24, 90, 227, 70, 8, 79, 21, 181, 159, 226 }, new byte[] { 217, 68, 34, 237, 91, 145, 4, 190, 124, 245, 164, 125, 153, 140, 8, 158, 114, 2, 49, 6, 195, 51, 103, 203, 74, 81, 51, 0, 23, 207, 236, 57, 214, 238, 175, 228, 209, 120, 50, 177, 187, 181, 94, 104, 158, 50, 72, 166, 98, 205, 52, 80, 82, 121, 214, 60, 38, 223, 142, 122, 207, 76, 4, 168, 211, 85, 64, 255, 17, 178, 163, 10, 129, 33, 91, 98, 105, 33, 76, 142, 40, 54, 50, 43, 86, 106, 53, 228, 241, 47, 148, 83, 215, 41, 228, 113, 18, 7, 251, 177, 18, 148, 201, 41, 81, 142, 142, 120, 240, 117, 137, 147, 113, 146, 194, 192, 231, 142, 14, 175, 242, 110, 120, 230, 74, 23, 116, 45 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(3834), new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 560, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 34, 41, 559, DateTimeKind.Local).AddTicks(3863));
        }
    }
}
