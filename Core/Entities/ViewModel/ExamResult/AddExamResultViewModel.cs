using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.ExamResult
{
    public class AddExamResultViewModel
    {
        public string? Notes { get; set; }
        public bool PassedExam { get; set; }
        public DateTime ResultDate { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int ExamTypeConfId { get; set; }
        public ExamTypeConfViewModel? ExamType { get; set; }
        public int CandidateId { get; set; }
        public CandidateViewModel? Candidate { get; set; }
    }
}
