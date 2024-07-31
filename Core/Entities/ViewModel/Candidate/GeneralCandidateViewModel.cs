using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Candidate
{
    public class GeneralCandidateViewModel
    {
        public List<CandidateViewModel> AllCandidate { get; set; }
        public CandidateViewModel SingleCandidate { get; set; }
        public AddCandidateViewModel AddCandidate { get; set; }
        public UpdateCandidateViewModel UpdateCandidate { get; set; }
        public DeleteCandidateViewModel DeleteCandidate { get; set; }
    }
}
