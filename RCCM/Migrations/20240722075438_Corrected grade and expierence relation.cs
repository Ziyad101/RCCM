using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RCCM.Migrations
{
    public partial class Correctedgradeandexpierencerelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Experience_ExperienceId",
                table: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Grade_ExperienceId",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Grade");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Experience",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Experience_GradeId",
                table: "Experience",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Grade_GradeId",
                table: "Experience",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Grade_GradeId",
                table: "Experience");

            migrationBuilder.DropIndex(
                name: "IX_Experience_GradeId",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Experience");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Grade",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Grade_ExperienceId",
                table: "Grade",
                column: "ExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Experience_ExperienceId",
                table: "Grade",
                column: "ExperienceId",
                principalTable: "Experience",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
