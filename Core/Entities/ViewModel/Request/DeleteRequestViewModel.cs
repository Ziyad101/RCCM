using Core.Entities.ViewModel.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Request
{
    public class DeleteRequestViewModel
    {
        public int RequestId { get; set; }
        public int RequestStatus { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; } 
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public CandidateViewModel Candidate { get; set; }
    }
}
