using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.ExamResult
{
    public class ExamResultViewModel
    {
        public int ExamResultId { get; set; }
        public string Notes { get; set; }
        public bool PassedExam { get; set; }
        public DateTime ResultDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ExamTypeConfId { get; set; }
        public ExamTypeConfViewModel ExamTypeConf { get; set; }
        public int CandidateId { get; set; }
        public CandidateViewModel Candidate { get; set; }
    }
}
