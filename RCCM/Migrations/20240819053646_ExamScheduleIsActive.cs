using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RCCM.Migrations
{
    public partial class ExamScheduleIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExamSchedule_Candidate_CandidateId",
                table: "CandidateExamSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExamSchedule_ExamTypeConf_ExamTypeConfId",
                table: "CandidateExamSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateExamSchedule",
                table: "CandidateExamSchedule");

            migrationBuilder.RenameTable(
                name: "CandidateExamSchedule",
                newName: "candidateExamSchedule");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateExamSchedule_ExamTypeConfId",
                table: "candidateExamSchedule",
                newName: "IX_candidateExamSchedule_ExamTypeConfId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateExamSchedule_CandidateId",
                table: "candidateExamSchedule",
                newName: "IX_candidateExamSchedule_CandidateId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "candidateExamSchedule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_candidateExamSchedule",
                table: "candidateExamSchedule",
                column: "CandidateExamScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_candidateExamSchedule_Candidate_CandidateId",
                table: "candidateExamSchedule",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "CandidateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_candidateExamSchedule_ExamTypeConf_ExamTypeConfId",
                table: "candidateExamSchedule",
                column: "ExamTypeConfId",
                principalTable: "ExamTypeConf",
                principalColumn: "ExamTypeConfId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_candidateExamSchedule_Candidate_CandidateId",
                table: "candidateExamSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_candidateExamSchedule_ExamTypeConf_ExamTypeConfId",
                table: "candidateExamSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_candidateExamSchedule",
                table: "candidateExamSchedule");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "candidateExamSchedule");

            migrationBuilder.RenameTable(
                name: "candidateExamSchedule",
                newName: "CandidateExamSchedule");

            migrationBuilder.RenameIndex(
                name: "IX_candidateExamSchedule_ExamTypeConfId",
                table: "CandidateExamSchedule",
                newName: "IX_CandidateExamSchedule_ExamTypeConfId");

            migrationBuilder.RenameIndex(
                name: "IX_candidateExamSchedule_CandidateId",
                table: "CandidateExamSchedule",
                newName: "IX_CandidateExamSchedule_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateExamSchedule",
                table: "CandidateExamSchedule",
                column: "CandidateExamScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExamSchedule_Candidate_CandidateId",
                table: "CandidateExamSchedule",
                column: "CandidateId",
                principalTable: "Candidate",
                principalColumn: "CandidateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExamSchedule_ExamTypeConf_ExamTypeConfId",
                table: "CandidateExamSchedule",
                column: "ExamTypeConfId",
                principalTable: "ExamTypeConf",
                principalColumn: "ExamTypeConfId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
