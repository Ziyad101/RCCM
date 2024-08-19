using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CandidateStatus
{
    public class GeneralCandidateStatusViewModel
    {
        public List<CandidateStatusViewModel> AllCandidateStatus { get; set; }
        public CandidateStatusViewModel SingleCandidateStatus { get; set; }
        public AddCandidateStatusViewModel AddCandidateStatus { get; set; }
        public UpdateCandidateStatusViewModel UpdateCandidateStatus { get; set; }
        public DeleteCandidateStatusViewModel DeleteCandidateStatus { get; set; }
    }
}
