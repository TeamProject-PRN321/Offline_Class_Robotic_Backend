using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Students");

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FullName", "Gender", "PassWordHash", "PassWordSalt", "PhotoUrl", "UserName" },
                values: new object[] { new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"), "23 Hcm", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhn537@gmail.com", "Nguyen Thanh Nhan", "Male", new byte[] { 12, 36, 242, 127, 55, 29, 106, 167, 199, 93, 155, 55, 205, 252, 203, 201, 90, 15, 141, 93, 42, 169, 226, 238, 61, 69, 5, 147, 23, 70, 206, 7, 50, 4, 220, 171, 47, 74, 168, 12, 111, 202, 200, 231, 69, 39, 176, 165, 200, 55, 73, 247, 104, 202, 112, 191, 253, 234, 168, 20, 182, 175, 247, 138 }, new byte[] { 133, 141, 34, 31, 126, 156, 31, 82, 43, 128, 60, 77, 1, 42, 109, 244, 196, 132, 70, 55, 174, 82, 173, 75, 194, 201, 185, 173, 172, 158, 115, 29, 92, 63, 30, 190, 231, 96, 104, 174, 160, 214, 54, 7, 38, 254, 195, 247, 59, 125, 84, 9, 99, 115, 161, 152, 164, 98, 144, 19, 189, 228, 47, 191, 187, 113, 204, 202, 177, 17, 55, 212, 224, 117, 187, 95, 57, 96, 236, 65, 128, 11, 28, 253, 130, 74, 71, 40, 35, 167, 226, 58, 215, 29, 111, 137, 234, 196, 34, 210, 136, 171, 51, 52, 177, 163, 108, 161, 18, 9, 201, 7, 104, 104, 54, 45, 58, 133, 103, 98, 229, 237, 16, 255, 116, 71, 140, 246 }, "132564487asjdhkahsdkj", "nhannt" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 43, 15, 711, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 43, 15, 711, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 43, 15, 711, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 43, 15, 711, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 43, 15, 711, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 43, 15, 711, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AppUserId", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "ParentId" },
                values: new object[] { new Guid("21f8abb6-34b9-44d2-a320-ef2988075dc2"), new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"), null, new DateTime(2024, 2, 25, 16, 43, 15, 710, DateTimeKind.Local).AddTicks(5366), false, null, null, new Guid("00000000-0000-0000-0000-000000000000") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("21f8abb6-34b9-44d2-a320-ef2988075dc2"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a22d7f6-6d94-4587-84d2-921c78970a91"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c477667-fbc0-4c85-9d2f-1f5a6da3edac"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 14, 34, 654, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("433ca17d-2bb8-4a98-91e6-5703365cb2fd"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 14, 34, 654, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("891e4e1c-bed5-4992-a978-fc969fdaf128"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 14, 34, 654, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a53d0cca-65d1-4b81-afe2-e735facd6c38"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 14, 34, 654, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b308c9a8-9a44-4662-b010-e4688fb8e019"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 14, 34, 654, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dc1c58f1-326b-43c0-a750-263bceee32be"),
                column: "Created",
                value: new DateTime(2024, 2, 25, 16, 14, 34, 654, DateTimeKind.Local).AddTicks(5003));
        }
    }
}
