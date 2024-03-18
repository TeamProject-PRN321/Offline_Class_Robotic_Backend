using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9c20d30e-ff04-4d21-a14f-ec6b5888a880"));

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
                columns: new[] { "Created", "StatusOfDevice" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5857), 2 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                columns: new[] { "Created", "StatusOfDevice" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 8, 11, 435, DateTimeKind.Local).AddTicks(5849), 1 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("03a11913-f7e2-481b-bf27-e297ae165380"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("9c20d30e-ff04-4d21-a14f-ec6b5888a880"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5133), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 245, 44, 113, 3, 223, 64, 74, 157, 7, 13, 148, 201, 2, 27, 129, 22, 99, 47, 50, 223, 34, 103, 53, 192, 230, 207, 226, 217, 21, 161, 223, 244, 80, 56, 45, 13, 111, 61, 37, 89, 25, 46, 128, 64, 76, 104, 248, 93, 13, 84, 36, 94, 42, 236, 180, 80, 242, 243, 94, 213, 135, 189, 3, 99 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 245, 44, 113, 3, 223, 64, 74, 157, 7, 13, 148, 201, 2, 27, 129, 22, 99, 47, 50, 223, 34, 103, 53, 192, 230, 207, 226, 217, 21, 161, 223, 244, 80, 56, 45, 13, 111, 61, 37, 89, 25, 46, 128, 64, 76, 104, 248, 93, 13, 84, 36, 94, 42, 236, 180, 80, 242, 243, 94, 213, 135, 189, 3, 99 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 245, 44, 113, 3, 223, 64, 74, 157, 7, 13, 148, 201, 2, 27, 129, 22, 99, 47, 50, 223, 34, 103, 53, 192, 230, 207, 226, 217, 21, 161, 223, 244, 80, 56, 45, 13, 111, 61, 37, 89, 25, 46, 128, 64, 76, 104, 248, 93, 13, 84, 36, 94, 42, 236, 180, 80, 242, 243, 94, 213, 135, 189, 3, 99 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 20, 46, 8, 186, 242, 66, 50, 20, 119, 137, 219, 196, 163, 40, 60, 107, 243, 158, 53, 133, 100, 158, 42, 163, 25, 122, 120, 65, 1, 23, 37, 153, 187, 25, 53, 123, 3, 232, 106, 154, 115, 154, 224, 49, 9, 46, 41, 246, 193, 110, 248, 41, 216, 181, 91, 176, 195, 253, 143, 27, 182, 163, 144, 19 }, new byte[] { 201, 112, 37, 225, 121, 48, 20, 74, 81, 212, 218, 63, 44, 58, 159, 136, 200, 45, 23, 140, 22, 76, 117, 1, 90, 67, 16, 213, 203, 32, 174, 221, 201, 49, 131, 55, 64, 221, 200, 243, 125, 70, 111, 89, 253, 162, 81, 172, 128, 29, 92, 189, 74, 26, 135, 43, 50, 140, 38, 78, 209, 187, 182, 62, 80, 225, 216, 249, 185, 226, 160, 186, 30, 92, 191, 97, 197, 200, 77, 250, 184, 171, 134, 154, 171, 114, 201, 96, 34, 226, 75, 24, 196, 194, 124, 57, 158, 207, 191, 71, 211, 121, 165, 44, 42, 0, 91, 89, 251, 14, 194, 210, 44, 20, 210, 107, 74, 130, 249, 211, 168, 236, 85, 174, 149, 12, 130, 150 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                columns: new[] { "Created", "StatusOfDevice" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5459), 1 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                columns: new[] { "Created", "StatusOfDevice" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5449), 0 });

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 171, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 12, 14, 4, 9, 170, DateTimeKind.Local).AddTicks(2045));
        }
    }
}
