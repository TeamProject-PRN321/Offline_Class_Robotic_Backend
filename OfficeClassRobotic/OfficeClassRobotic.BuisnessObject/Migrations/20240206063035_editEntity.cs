using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeClassRobotic.BuisnessObject.Migrations
{
    /// <inheritdoc />
    public partial class editEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_TrungTamRobotics_TrungTamRoboticID",
                table: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_GiaoTrinhs_SubjectID",
                table: "GiaoTrinhs");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SubjectID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_ClassID",
                table: "Attendances");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TrungTamRoboticID",
                table: "Classrooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_TrungTamRobotics_TrungTamRoboticID",
                table: "Classrooms",
                column: "TrungTamRoboticID",
                principalTable: "TrungTamRobotics",
                principalColumn: "TrungTamRoboticID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_TrungTamRobotics_TrungTamRoboticID",
                table: "Classrooms");

            migrationBuilder.DropIndex(
                name: "IX_GiaoTrinhs_SubjectID",
                table: "GiaoTrinhs");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SubjectID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_ClassID",
                table: "Attendances");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrungTamRoboticID",
                table: "Classrooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_TrungTamRobotics_TrungTamRoboticID",
                table: "Classrooms",
                column: "TrungTamRoboticID",
                principalTable: "TrungTamRobotics",
                principalColumn: "TrungTamRoboticID");
        }
    }
}
