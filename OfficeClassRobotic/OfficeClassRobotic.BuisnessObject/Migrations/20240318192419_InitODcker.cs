﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class InitODcker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("687fb4f4-115a-4766-862b-dae59864bfe9"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("57eee92c-7b44-4388-a079-f08bdf2bcb10"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9663), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 233, 143, 64, 151, 152, 189, 62, 228, 232, 157, 246, 197, 207, 37, 66, 100, 46, 108, 20, 33, 203, 173, 239, 135, 196, 132, 236, 107, 197, 145, 215, 250, 21, 78, 81, 19, 206, 15, 11, 32, 89, 179, 52, 76, 35, 176, 125, 72, 64, 66, 81, 148, 131, 136, 51, 180, 173, 90, 144, 0, 237, 191, 77, 18 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 233, 143, 64, 151, 152, 189, 62, 228, 232, 157, 246, 197, 207, 37, 66, 100, 46, 108, 20, 33, 203, 173, 239, 135, 196, 132, 236, 107, 197, 145, 215, 250, 21, 78, 81, 19, 206, 15, 11, 32, 89, 179, 52, 76, 35, 176, 125, 72, 64, 66, 81, 148, 131, 136, 51, 180, 173, 90, 144, 0, 237, 191, 77, 18 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 233, 143, 64, 151, 152, 189, 62, 228, 232, 157, 246, 197, 207, 37, 66, 100, 46, 108, 20, 33, 203, 173, 239, 135, 196, 132, 236, 107, 197, 145, 215, 250, 21, 78, 81, 19, 206, 15, 11, 32, 89, 179, 52, 76, 35, 176, 125, 72, 64, 66, 81, 148, 131, 136, 51, 180, 173, 90, 144, 0, 237, 191, 77, 18 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 90, 237, 48, 182, 28, 120, 18, 247, 169, 157, 213, 222, 190, 62, 141, 7, 134, 129, 94, 38, 70, 121, 23, 239, 73, 90, 197, 169, 228, 250, 255, 0, 179, 182, 197, 109, 170, 234, 197, 226, 226, 86, 248, 41, 244, 154, 14, 34, 47, 0, 221, 227, 98, 209, 158, 19, 131, 169, 9, 133, 245, 158, 57, 244 }, new byte[] { 188, 16, 249, 135, 150, 134, 181, 14, 221, 207, 167, 209, 123, 32, 216, 161, 162, 103, 218, 217, 207, 220, 210, 139, 255, 65, 27, 75, 108, 86, 207, 123, 94, 236, 42, 139, 252, 90, 223, 146, 105, 20, 70, 0, 154, 64, 133, 180, 31, 24, 68, 18, 89, 188, 239, 121, 174, 156, 51, 129, 65, 32, 116, 254, 91, 33, 201, 45, 206, 92, 55, 210, 70, 58, 57, 80, 56, 248, 68, 229, 150, 223, 35, 7, 133, 159, 158, 163, 27, 22, 194, 16, 31, 53, 97, 158, 5, 173, 228, 165, 120, 240, 120, 3, 203, 202, 22, 150, 64, 15, 57, 86, 120, 0, 165, 244, 194, 184, 108, 52, 31, 107, 142, 129, 189, 214, 51, 179 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.InsertData(
                table: "SubjectGradingWeights",
                columns: new[] { "Id", "AssesessmentType", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "SubjectID", "WeightPercentage" },
                values: new object[,]
                {
                    { new Guid("048f786e-f84f-4341-ae89-0d373f604596"), "Kiem tra 1T", null, new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(267), false, null, null, new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"), 0 },
                    { new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"), "Kiem tra 15p", null, new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(262), false, null, null, new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"), 0 }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 19, 2, 24, 19, 79, DateTimeKind.Local).AddTicks(508));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("57eee92c-7b44-4388-a079-f08bdf2bcb10"));

            migrationBuilder.DeleteData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("048f786e-f84f-4341-ae89-0d373f604596"));

            migrationBuilder.DeleteData(
                table: "SubjectGradingWeights",
                keyColumn: "Id",
                keyValue: new Guid("768175a0-688f-4972-ab8c-260f6fe43c35"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("687fb4f4-115a-4766-862b-dae59864bfe9"), new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"), null, new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6041), false, null, null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("275c605e-3d04-437d-8a7d-208249412cec"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 160, 39, 124, 10, 246, 154, 151, 96, 142, 216, 221, 144, 98, 226, 20, 171, 228, 10, 166, 255, 102, 84, 156, 180, 193, 14, 233, 11, 30, 59, 102, 213, 120, 239, 64, 212, 34, 248, 81, 6, 100, 151, 39, 146, 55, 84, 174, 90, 38, 98, 223, 66, 244, 216, 81, 223, 138, 134, 238, 88, 58, 119, 216, 99 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b82e13-b1fc-425d-a2b3-8b821405bfd0"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 160, 39, 124, 10, 246, 154, 151, 96, 142, 216, 221, 144, 98, 226, 20, 171, 228, 10, 166, 255, 102, 84, 156, 180, 193, 14, 233, 11, 30, 59, 102, 213, 120, 239, 64, 212, 34, 248, 81, 6, 100, 151, 39, 146, 55, 84, 174, 90, 38, 98, 223, 66, 244, 216, 81, 223, 138, 134, 238, 88, 58, 119, 216, 99 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4e5e39dc-7a22-4787-9083-70335fa2489c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ddd65ff-16a1-4fd1-acbf-c913f0cce37c"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64863e62-104c-49ee-a57e-b066936d8e8d"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("75653469-5fdd-4639-9be7-2c8fca8cecc5"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae50067c-00bc-49e2-a20c-500696a2f954"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("af7a0942-0459-4364-b8c8-3737a4edfff4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf835a7d-d002-4c9f-8bd6-0e2d321447c4"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 160, 39, 124, 10, 246, 154, 151, 96, 142, 216, 221, 144, 98, 226, 20, 171, 228, 10, 166, 255, 102, 84, 156, 180, 193, 14, 233, 11, 30, 59, 102, 213, 120, 239, 64, 212, 34, 248, 81, 6, 100, 151, 39, 146, 55, 84, 174, 90, 38, 98, 223, 66, 244, 216, 81, 223, 138, 134, 238, 88, 58, 119, 216, 99 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("da053af4-cdf1-4a6b-8506-2e3939ef6351"),
                columns: new[] { "PassWordHash", "PassWordSalt" },
                values: new object[] { new byte[] { 158, 157, 190, 205, 56, 127, 125, 11, 139, 234, 10, 248, 164, 149, 118, 32, 36, 124, 138, 104, 93, 128, 181, 129, 210, 63, 193, 149, 44, 206, 234, 141, 21, 73, 194, 230, 125, 230, 70, 235, 185, 79, 79, 129, 138, 47, 6, 104, 72, 184, 185, 193, 108, 29, 196, 244, 162, 177, 254, 248, 187, 103, 173, 192 }, new byte[] { 47, 51, 53, 12, 198, 229, 207, 117, 42, 134, 215, 197, 205, 4, 105, 139, 158, 10, 161, 249, 38, 125, 146, 51, 130, 17, 116, 251, 180, 119, 192, 124, 13, 184, 8, 254, 191, 2, 152, 39, 77, 138, 211, 83, 182, 248, 6, 0, 26, 63, 241, 87, 55, 2, 218, 77, 146, 175, 109, 235, 1, 165, 8, 148, 14, 195, 87, 111, 138, 216, 121, 254, 52, 130, 221, 198, 129, 42, 30, 173, 100, 214, 235, 246, 196, 235, 49, 112, 95, 190, 241, 35, 32, 34, 126, 131, 42, 34, 215, 46, 190, 155, 250, 17, 248, 236, 4, 43, 222, 197, 50, 113, 164, 17, 165, 42, 49, 149, 53, 125, 90, 106, 133, 141, 174, 80, 47, 89 } });

            migrationBuilder.UpdateData(
                table: "ClassSchedule",
                keyColumn: "Id",
                keyValue: new Guid("4e1cba33-b0cf-4274-8797-6ab39788141f"),
                columns: new[] { "Created", "DateStudy" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 31, 44, 784, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 3, 18, 23, 31, 44, 784, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("381d2e33-67e5-4ce5-b8cc-c39bd523fe8b"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("29f67cfd-ba37-4b70-852a-4af223b7788a"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("5f59c98d-50f9-4f5e-911e-d28648ec43b1"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("a9770be8-9b13-4d63-a78d-c9d2efaa79ec"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2e283a6-5bf5-4d27-a2c2-994cb6d781e9"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("958e60a2-fa2d-4437-b639-316a569f3ab9"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("bf5b9e8e-4b5d-4fd2-8f45-b070558c64c0"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: new Guid("dff2458c-3f40-423b-8aa9-d7588a4ae4fe"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "GiaoTrinhs",
                keyColumn: "Id",
                keyValue: new Guid("c12ea77c-c707-44c0-b3ce-420f2ff4ecd9"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 784, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("07c7d0e7-273e-4819-ad69-0a875ef8f021"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b295a2a-4bf5-45c1-bf87-4e04f1eff028"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9aca-27da-415b-a468-b367613a2488"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 784, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3ce37d46-18e9-492d-a28e-2665b0d95a64"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("822eb9c1-d410-4e17-9b70-bb8512112ae3"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88de6bcd-e510-40d8-8f29-a06009cb195c"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a2cd9f87-17f7-45cc-a9da-88502a010042"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fec8b32d-bc9a-4fbb-94e6-5871e3ee9a63"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54eebe9e-2a5b-4a82-8522-1e7cd2aa4d57"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 784, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("53525c34-3437-4b3b-946c-e9be0a60c0c3"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("776afbe6-9133-4dbe-b8c0-f5a23f3fe505"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 785, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "TrungTamRobotics",
                keyColumn: "Id",
                keyValue: new Guid("5f4e0944-497b-4c33-9d5d-86f8824c8b95"),
                column: "Created",
                value: new DateTime(2024, 3, 18, 23, 31, 44, 784, DateTimeKind.Local).AddTicks(4060));
        }
    }
}
