using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class EditEntity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GiaoTrinhs_SubjectID",
                table: "GiaoTrinhs");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SubjectID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_ClassID",
                table: "Attendances");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoTrinhs_SubjectID",
                table: "GiaoTrinhs",
                column: "SubjectID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SubjectID",
                table: "Classes",
                column: "SubjectID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ClassID",
                table: "Attendances",
                column: "ClassID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GiaoTrinhs_SubjectID",
                table: "GiaoTrinhs");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SubjectID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_ClassID",
                table: "Attendances");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoTrinhs_SubjectID",
                table: "GiaoTrinhs",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SubjectID",
                table: "Classes",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ClassID",
                table: "Attendances",
                column: "ClassID");
        }
    }
}
