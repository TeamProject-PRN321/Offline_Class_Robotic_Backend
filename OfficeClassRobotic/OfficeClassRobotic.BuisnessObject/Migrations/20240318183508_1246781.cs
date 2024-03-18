using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class _1246781 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("0e6cd2a4-c4fd-4c6e-aa7a-7200edce90e6"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("577057c6-4006-426a-9187-e7222b9f1ad7"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(3971), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 222, 167, 180, 249, 209, 184, 198, 232, 193, 48, 25, 45, 115, 184, 148, 100, 16, 131, 136, 159, 35, 100, 242, 118, 174, 98, 188, 159, 118, 132, 68, 199, 47, 28, 153, 6, 2, 44, 238, 200, 43, 11, 192, 255, 254, 15, 89, 124, 24, 173, 212, 43, 208, 34, 222, 140, 24, 153, 253, 242, 138, 169, 81, 109 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 222, 167, 180, 249, 209, 184, 198, 232, 193, 48, 25, 45, 115, 184, 148, 100, 16, 131, 136, 159, 35, 100, 242, 118, 174, 98, 188, 159, 118, 132, 68, 199, 47, 28, 153, 6, 2, 44, 238, 200, 43, 11, 192, 255, 254, 15, 89, 124, 24, 173, 212, 43, 208, 34, 222, 140, 24, 153, 253, 242, 138, 169, 81, 109 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 222, 167, 180, 249, 209, 184, 198, 232, 193, 48, 25, 45, 115, 184, 148, 100, 16, 131, 136, 159, 35, 100, 242, 118, 174, 98, 188, 159, 118, 132, 68, 199, 47, 28, 153, 6, 2, 44, 238, 200, 43, 11, 192, 255, 254, 15, 89, 124, 24, 173, 212, 43, 208, 34, 222, 140, 24, 153, 253, 242, 138, 169, 81, 109 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 159, 57, 42, 28, 98, 78, 73, 130, 184, 127, 134, 162, 36, 198, 199, 245, 136, 112, 11, 238, 184, 70, 215, 79, 178, 153, 194, 60, 240, 218, 111, 50, 55, 176, 61, 162, 85, 222, 90, 178, 139, 62, 154, 7, 212, 76, 98, 251, 112, 89, 161, 56, 151, 47, 234, 211, 194, 152, 218, 9, 74, 187, 254, 169 }, new byte[] { 34, 130, 114, 142, 194, 53, 150, 190, 141, 74, 43, 192, 188, 104, 176, 196, 80, 236, 77, 199, 41, 232, 237, 180, 52, 173, 24, 58, 189, 210, 71, 130, 217, 171, 85, 117, 85, 102, 73, 110, 71, 59, 25, 25, 235, 29, 44, 255, 66, 218, 65, 15, 78, 239, 242, 246, 110, 176, 65, 123, 215, 31, 89, 17, 164, 45, 71, 134, 45, 250, 217, 31, 165, 6, 202, 31, 16, 125, 112, 61, 167, 26, 38, 80, 236, 219, 60, 235, 237, 124, 208, 65, 252, 73, 118, 43, 121, 233, 83, 99, 27, 203, 220, 143, 120, 245, 169, 108, 208, 255, 15, 211, 72, 173, 16, 221, 157, 128, 55, 208, 191, 134, 173, 197, 242, 68, 48, 138 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(3854), new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 346, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 8, 345, DateTimeKind.Local).AddTicks(3943));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("577057c6-4006-426a-9187-e7222b9f1ad7"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("0e6cd2a4-c4fd-4c6e-aa7a-7200edce90e6"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2949), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 108, 149, 224, 211, 217, 102, 222, 58, 18, 234, 206, 81, 213, 70, 207, 87, 56, 178, 33, 232, 8, 9, 12, 38, 73, 212, 148, 177, 108, 225, 151, 227, 52, 53, 33, 217, 16, 205, 176, 3, 71, 146, 207, 240, 68, 125, 225, 192, 247, 122, 53, 152, 87, 97, 214, 81, 109, 224, 98, 134, 96, 143, 11 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 108, 149, 224, 211, 217, 102, 222, 58, 18, 234, 206, 81, 213, 70, 207, 87, 56, 178, 33, 232, 8, 9, 12, 38, 73, 212, 148, 177, 108, 225, 151, 227, 52, 53, 33, 217, 16, 205, 176, 3, 71, 146, 207, 240, 68, 125, 225, 192, 247, 122, 53, 152, 87, 97, 214, 81, 109, 224, 98, 134, 96, 143, 11 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 96, 108, 149, 224, 211, 217, 102, 222, 58, 18, 234, 206, 81, 213, 70, 207, 87, 56, 178, 33, 232, 8, 9, 12, 38, 73, 212, 148, 177, 108, 225, 151, 227, 52, 53, 33, 217, 16, 205, 176, 3, 71, 146, 207, 240, 68, 125, 225, 192, 247, 122, 53, 152, 87, 97, 214, 81, 109, 224, 98, 134, 96, 143, 11 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 248, 113, 153, 32, 149, 40, 252, 152, 243, 92, 6, 84, 12, 93, 226, 213, 34, 148, 239, 175, 35, 143, 104, 182, 25, 0, 235, 57, 81, 254, 193, 242, 191, 128, 192, 41, 129, 253, 61, 115, 79, 178, 113, 12, 89, 140, 142, 62, 138, 45, 98, 217, 178, 218, 123, 201, 44, 57, 185, 38, 63, 176, 156, 68 }, new byte[] { 24, 74, 123, 182, 95, 245, 7, 28, 132, 229, 229, 225, 120, 55, 244, 39, 44, 103, 105, 44, 234, 175, 119, 55, 78, 156, 242, 167, 118, 145, 30, 181, 216, 21, 8, 203, 42, 70, 245, 133, 121, 15, 225, 149, 121, 239, 63, 75, 144, 161, 162, 201, 250, 26, 110, 231, 41, 12, 174, 118, 205, 228, 212, 15, 33, 253, 188, 238, 160, 198, 119, 151, 30, 88, 209, 168, 92, 246, 206, 220, 8, 245, 68, 222, 19, 15, 128, 146, 208, 231, 76, 20, 132, 223, 15, 35, 76, 140, 2, 246, 89, 179, 194, 8, 104, 155, 61, 166, 195, 172, 0, 92, 233, 206, 205, 38, 160, 240, 111, 101, 152, 110, 133, 138, 82, 233, 177, 217 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3307), new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 876, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 1, 35, 1, 875, DateTimeKind.Local).AddTicks(3336));
        }
    }
}
