using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RCCM.Migrations
{
    public partial class fixedInterview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Interview_CandidateId",
                table: "Interview");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_CandidateId",
                table: "Interview",
                column: "CandidateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Interview_CandidateId",
                table: "Interview");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_CandidateId",
                table: "Interview",
                column: "CandidateId",
                unique: true);
        }
    }
}
