using Core.Entities.ViewModel.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Interview
{
    public class DeleteInterviewViewModel
    {
        public int InterviewId { get; set; }
        public DateTime InterviewDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int CandidateId { get; set; }
        public CandidateViewModel Candidate { get; set; }
    }
}
