using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("df0b5b1f-8ec8-4404-a1b9-c7fb5476b335"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("e81145b3-7506-4be2-8333-e39d4cf82ac6"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5115), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 128, 170, 101, 177, 2, 69, 143, 192, 231, 177, 153, 110, 45, 236, 207, 93, 238, 104, 43, 223, 84, 165, 113, 71, 35, 21, 62, 210, 81, 198, 186, 221, 60, 189, 181, 105, 147, 197, 97, 100, 25, 190, 82, 157, 65, 88, 117, 68, 224, 138, 10, 125, 38, 154, 237, 3, 145, 87, 93, 173, 125, 159, 204 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 128, 170, 101, 177, 2, 69, 143, 192, 231, 177, 153, 110, 45, 236, 207, 93, 238, 104, 43, 223, 84, 165, 113, 71, 35, 21, 62, 210, 81, 198, 186, 221, 60, 189, 181, 105, 147, 197, 97, 100, 25, 190, 82, 157, 65, 88, 117, 68, 224, 138, 10, 125, 38, 154, 237, 3, 145, 87, 93, 173, 125, 159, 204 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 121, 128, 170, 101, 177, 2, 69, 143, 192, 231, 177, 153, 110, 45, 236, 207, 93, 238, 104, 43, 223, 84, 165, 113, 71, 35, 21, 62, 210, 81, 198, 186, 221, 60, 189, 181, 105, 147, 197, 97, 100, 25, 190, 82, 157, 65, 88, 117, 68, 224, 138, 10, 125, 38, 154, 237, 3, 145, 87, 93, 173, 125, 159, 204 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 167, 11, 198, 226, 171, 171, 236, 123, 20, 209, 75, 111, 33, 131, 58, 193, 114, 133, 135, 160, 202, 246, 59, 142, 212, 89, 106, 63, 27, 156, 89, 165, 237, 190, 81, 225, 183, 42, 177, 75, 85, 214, 69, 11, 204, 13, 70, 123, 181, 228, 234, 79, 62, 33, 162, 97, 84, 112, 187, 176, 60, 164, 81, 117 }, new byte[] { 218, 91, 131, 102, 238, 29, 229, 179, 126, 192, 210, 252, 29, 119, 53, 212, 98, 167, 0, 14, 75, 130, 51, 92, 251, 3, 34, 31, 34, 44, 234, 253, 99, 120, 153, 208, 39, 140, 75, 127, 226, 132, 1, 12, 136, 165, 35, 207, 24, 2, 217, 50, 217, 77, 109, 229, 158, 184, 174, 246, 22, 205, 222, 141, 249, 164, 189, 200, 20, 102, 221, 230, 209, 173, 197, 196, 194, 12, 171, 231, 144, 162, 190, 5, 45, 59, 157, 130, 216, 136, 181, 69, 234, 130, 185, 135, 55, 15, 100, 37, 155, 83, 69, 200, 139, 48, 86, 130, 47, 170, 212, 177, 249, 255, 196, 149, 64, 42, 224, 196, 154, 31, 116, 120, 211, 182, 21, 112 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 725, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 43, 2, 724, DateTimeKind.Local).AddTicks(5946));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e81145b3-7506-4be2-8333-e39d4cf82ac6"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("df0b5b1f-8ec8-4404-a1b9-c7fb5476b335"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4310), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 132, 243, 17, 67, 166, 156, 189, 96, 0, 94, 4, 24, 161, 63, 169, 17, 142, 90, 151, 168, 48, 163, 247, 51, 70, 94, 64, 182, 244, 119, 129, 69, 249, 204, 27, 101, 207, 244, 122, 4, 213, 14, 205, 190, 231, 108, 44, 92, 171, 0, 178, 174, 96, 53, 175, 136, 176, 176, 71, 104, 99, 177, 114, 166 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 132, 243, 17, 67, 166, 156, 189, 96, 0, 94, 4, 24, 161, 63, 169, 17, 142, 90, 151, 168, 48, 163, 247, 51, 70, 94, 64, 182, 244, 119, 129, 69, 249, 204, 27, 101, 207, 244, 122, 4, 213, 14, 205, 190, 231, 108, 44, 92, 171, 0, 178, 174, 96, 53, 175, 136, 176, 176, 71, 104, 99, 177, 114, 166 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 132, 243, 17, 67, 166, 156, 189, 96, 0, 94, 4, 24, 161, 63, 169, 17, 142, 90, 151, 168, 48, 163, 247, 51, 70, 94, 64, 182, 244, 119, 129, 69, 249, 204, 27, 101, 207, 244, 122, 4, 213, 14, 205, 190, 231, 108, 44, 92, 171, 0, 178, 174, 96, 53, 175, 136, 176, 176, 71, 104, 99, 177, 114, 166 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 175, 223, 68, 86, 86, 164, 94, 243, 136, 36, 236, 67, 67, 88, 18, 119, 12, 233, 213, 82, 67, 209, 215, 140, 10, 0, 206, 30, 131, 62, 69, 157, 22, 219, 19, 153, 232, 58, 107, 100, 192, 125, 5, 131, 109, 199, 49, 116, 162, 246, 66, 55, 157, 242, 234, 89, 85, 205, 74, 255, 56, 199, 7, 37 }, new byte[] { 52, 142, 105, 237, 243, 159, 76, 177, 76, 124, 230, 122, 4, 64, 219, 26, 27, 208, 48, 245, 105, 64, 159, 101, 109, 167, 97, 253, 172, 23, 70, 73, 96, 175, 91, 237, 201, 42, 208, 144, 183, 40, 203, 142, 220, 136, 162, 60, 100, 187, 50, 21, 75, 35, 218, 31, 32, 146, 74, 69, 41, 217, 134, 248, 240, 130, 85, 165, 229, 10, 59, 174, 163, 24, 125, 60, 187, 241, 72, 11, 9, 196, 225, 220, 43, 40, 243, 68, 173, 198, 130, 102, 83, 191, 36, 119, 52, 169, 17, 5, 2, 93, 124, 190, 243, 74, 81, 235, 99, 183, 27, 62, 57, 32, 67, 29, 133, 214, 191, 221, 102, 58, 21, 255, 177, 161, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 815, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 36, 19, 814, DateTimeKind.Local).AddTicks(5056));
        }
    }
}
