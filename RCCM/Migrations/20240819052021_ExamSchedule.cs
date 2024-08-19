using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RCCM.Migrations
{
    public partial class ExamSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateExamSchedule",
                columns: table => new
                {
                    CandidateExamScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    ExamTypeConfId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateExamSchedule", x => x.CandidateExamScheduleId);
                    table.ForeignKey(
                        name: "FK_CandidateExamSchedule_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateExamSchedule_ExamTypeConf_ExamTypeConfId",
                        column: x => x.ExamTypeConfId,
                        principalTable: "ExamTypeConf",
                        principalColumn: "ExamTypeConfId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExamSchedule_CandidateId",
                table: "CandidateExamSchedule",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExamSchedule_ExamTypeConfId",
                table: "CandidateExamSchedule",
                column: "ExamTypeConfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateExamSchedule");
        }
    }
}
