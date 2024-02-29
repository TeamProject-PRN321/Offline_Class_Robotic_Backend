using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class MoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("77d7d079-b309-424c-a62b-3f942caedc20"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("34521f3a-a7bf-4262-be95-63a247371583"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6938), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 157, 36, 79, 129, 21, 225, 228, 127, 150, 245, 31, 82, 201, 250, 49, 201, 72, 232, 149, 212, 156, 158, 247, 133, 172, 230, 109, 132, 119, 198, 148, 184, 146, 213, 179, 173, 149, 17, 28, 203, 123, 72, 180, 220, 159, 161, 117, 71, 61, 8, 150, 19, 212, 42, 25, 133, 216, 205, 8, 191, 107, 43, 198, 100 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 157, 36, 79, 129, 21, 225, 228, 127, 150, 245, 31, 82, 201, 250, 49, 201, 72, 232, 149, 212, 156, 158, 247, 133, 172, 230, 109, 132, 119, 198, 148, 184, 146, 213, 179, 173, 149, 17, 28, 203, 123, 72, 180, 220, 159, 161, 117, 71, 61, 8, 150, 19, 212, 42, 25, 133, 216, 205, 8, 191, 107, 43, 198, 100 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 157, 36, 79, 129, 21, 225, 228, 127, 150, 245, 31, 82, 201, 250, 49, 201, 72, 232, 149, 212, 156, 158, 247, 133, 172, 230, 109, 132, 119, 198, 148, 184, 146, 213, 179, 173, 149, 17, 28, 203, 123, 72, 180, 220, 159, 161, 117, 71, 61, 8, 150, 19, 212, 42, 25, 133, 216, 205, 8, 191, 107, 43, 198, 100 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 155, 5, 184, 160, 50, 126, 28, 32, 187, 154, 24, 158, 194, 115, 53, 189, 236, 80, 121, 211, 4, 41, 175, 41, 172, 150, 113, 131, 147, 24, 24, 113, 86, 121, 129, 71, 51, 136, 242, 166, 148, 56, 60, 35, 42, 226, 240, 12, 180, 242, 227, 227, 127, 88, 123, 144, 53, 101, 119, 89, 25, 97, 10, 70 }, new byte[] { 214, 232, 177, 145, 246, 92, 117, 85, 91, 69, 159, 245, 51, 93, 94, 85, 89, 2, 114, 128, 83, 255, 51, 221, 83, 141, 121, 131, 145, 240, 50, 149, 30, 139, 33, 82, 140, 46, 59, 174, 176, 66, 127, 26, 128, 88, 6, 210, 74, 13, 185, 14, 140, 34, 176, 19, 196, 146, 60, 172, 24, 196, 149, 16, 66, 208, 158, 1, 112, 160, 198, 214, 76, 70, 167, 122, 98, 140, 44, 255, 128, 49, 115, 137, 119, 1, 100, 103, 201, 40, 179, 254, 35, 203, 195, 40, 241, 169, 59, 102, 123, 97, 57, 125, 110, 225, 193, 159, 112, 198, 32, 202, 80, 6, 1, 43, 157, 31, 18, 193, 198, 202, 13, 21, 107, 242, 240, 138 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "ClassRoomName", "CreateBy", "Created", "Description", "IsDeleted", "LastModified", "LastModifiedBy", "TrungTamRoboticId" },
                values: new object[,]
                {
                    { new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"), "P.203", null, new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9036), "Tầng 2, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") },
                    { new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"), "P.303", null, new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9033), "Tầng 3, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") },
                    { new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"), "P.103", null, new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9040), "Tầng 1, phòng số 3", false, null, null, new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95") }
                });

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 155, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 2, 29, 1, 53, 7, 154, DateTimeKind.Local).AddTicks(9060));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("34521f3a-a7bf-4262-be95-63a247371583"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("77d7d079-b309-424c-a62b-3f942caedc20"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3830), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 188, 172, 80, 207, 148, 83, 176, 234, 182, 90, 250, 5, 54, 45, 60, 80, 4, 3, 126, 116, 73, 108, 5, 29, 0, 8, 47, 25, 180, 42, 8, 51, 117, 190, 6, 131, 194, 111, 142, 158, 76, 54, 215, 36, 220, 106, 148, 129, 241, 37, 214, 42, 249, 146, 229, 52, 217, 231, 254, 228, 123, 42, 0, 182 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 188, 172, 80, 207, 148, 83, 176, 234, 182, 90, 250, 5, 54, 45, 60, 80, 4, 3, 126, 116, 73, 108, 5, 29, 0, 8, 47, 25, 180, 42, 8, 51, 117, 190, 6, 131, 194, 111, 142, 158, 76, 54, 215, 36, 220, 106, 148, 129, 241, 37, 214, 42, 249, 146, 229, 52, 217, 231, 254, 228, 123, 42, 0, 182 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 188, 172, 80, 207, 148, 83, 176, 234, 182, 90, 250, 5, 54, 45, 60, 80, 4, 3, 126, 116, 73, 108, 5, 29, 0, 8, 47, 25, 180, 42, 8, 51, 117, 190, 6, 131, 194, 111, 142, 158, 76, 54, 215, 36, 220, 106, 148, 129, 241, 37, 214, 42, 249, 146, 229, 52, 217, 231, 254, 228, 123, 42, 0, 182 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 178, 160, 139, 138, 93, 61, 145, 192, 0, 232, 113, 193, 246, 29, 125, 233, 125, 13, 48, 163, 2, 193, 84, 77, 134, 130, 49, 5, 27, 20, 65, 124, 118, 175, 145, 11, 202, 36, 72, 207, 7, 99, 77, 254, 34, 63, 210, 148, 232, 236, 202, 118, 3, 193, 107, 121, 234, 90, 10, 68, 148, 187, 160, 165 }, new byte[] { 153, 33, 26, 97, 84, 133, 138, 107, 138, 45, 73, 226, 27, 221, 60, 56, 44, 165, 3, 45, 124, 37, 125, 164, 105, 24, 40, 160, 239, 103, 55, 187, 65, 214, 151, 127, 91, 21, 135, 76, 190, 122, 228, 65, 77, 107, 202, 201, 125, 107, 242, 126, 110, 100, 90, 85, 66, 222, 200, 56, 55, 138, 7, 55, 246, 152, 129, 168, 94, 152, 80, 192, 53, 249, 213, 90, 34, 10, 14, 207, 71, 200, 122, 32, 66, 208, 124, 182, 254, 241, 13, 59, 32, 176, 241, 212, 54, 94, 155, 15, 219, 15, 206, 112, 101, 233, 30, 209, 45, 4, 18, 190, 243, 69, 78, 76, 40, 132, 95, 70, 156, 101, 198, 38, 7, 23, 36, 156 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4483), new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 936, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 2, 28, 2, 57, 40, 934, DateTimeKind.Local).AddTicks(4548));
        }
    }
}
