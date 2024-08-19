using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CandidateExamSchedule
{
    public class AddCandidateExamScheduleViewModel
    {
        public DateTime ExamDate { get; set; }
        public bool IsActive { get; set; } = true;
        public CandidateViewModel Candidate { get; set; }
        public ExamTypeConfViewModel ExamTypeConf { get; set; }
        public List<CandidateViewModel> Candidates { get; set; }
        public List<ExamTypeConfViewModel> ExamTypes { get; set; }

        public  int CandidateId { get; set; }
        public int ExamTypeConfId { get; set; }
    }
}
