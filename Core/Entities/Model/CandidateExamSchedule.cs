using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class CandidateExamSchedule
    {
        [Key]
        public int CandidateExamScheduleId { get; set; }
        public DateTime ExamDate { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        [ForeignKey("ExamTypeConf")]
        public int ExamTypeConfId { get; set; }
        public ExamTypeConf ExamTypeConf { get; set; }
    }
}
