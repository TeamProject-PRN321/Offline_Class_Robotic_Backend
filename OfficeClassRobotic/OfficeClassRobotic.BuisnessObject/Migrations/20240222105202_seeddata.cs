using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "Birthday", "CreateBy", "Created", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("04914460-7b5d-44a7-84a2-7eb8aa5ea92a"), "Address2", new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", new DateTime(2024, 2, 22, 17, 52, 2, 272, DateTimeKind.Local).AddTicks(4567), false, null, null, "Admin2" },
                    { new Guid("06540c20-d6b8-4770-8639-caf8e9c92724"), "Address1", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", new DateTime(2024, 2, 22, 17, 52, 2, 272, DateTimeKind.Local).AddTicks(4555), false, null, null, "Admin1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("04914460-7b5d-44a7-84a2-7eb8aa5ea92a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("06540c20-d6b8-4770-8639-caf8e9c92724"));
        }
    }
}
