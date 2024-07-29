using Core.Entities.ViewModel.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Interview
{
    public class AddInterviewViewModel
    {
        public DateTime InterviewDate { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int CandidateId { get; set; }
        public List<CandidateViewModel> Candidates { get; set; }
    }
}
