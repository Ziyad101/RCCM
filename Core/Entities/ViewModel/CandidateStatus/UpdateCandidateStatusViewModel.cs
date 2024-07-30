using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CandidateStatus
{
    public  class UpdateCandidateStatusViewModel
    {
        public int CandidateStatusId { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
