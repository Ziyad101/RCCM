using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RCCM.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InterviewResult_InterviewId",
                table: "InterviewResult");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewResult_InterviewId",
                table: "InterviewResult",
                column: "InterviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InterviewResult_InterviewId",
                table: "InterviewResult");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewResult_InterviewId",
                table: "InterviewResult",
                column: "InterviewId",
                unique: true);
        }
    }
}
