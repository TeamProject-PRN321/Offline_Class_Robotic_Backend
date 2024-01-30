using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class createTableAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParnetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParnetID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "date", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Parents",
                        principalColumn: "ParnetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "ParnetID", "Address", "Birthday", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Address 1", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parent 1", "123456789" },
                    { 2, "Address 2", new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parent 2", "987654321" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Address", "Birthday", "Name", "ParentID" },
                values: new object[,]
                {
                    { 1, "Student Address 1", new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student 1", 1 },
                    { 2, "Student Address 2", new DateTime(1998, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student 2", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentID",
                table: "Students",
                column: "ParentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Parents");
        }
    }
}
