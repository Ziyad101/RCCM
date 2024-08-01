using Core.Entities.ViewModel.CandidateStatus;
using Core.Entities.ViewModel.Major;
using Core.Entities.ViewModel.Nationality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Candidate
{
    public class GeneralCandidateViewModel
    {
        public List<CandidateViewModel> AllCandidate { get; set; } = new List<CandidateViewModel>();
        public CandidateViewModel SingleCandidate { get; set; }
        public AddCandidateViewModel AddCandidate { get; set; }
        public UpdateCandidateViewModel UpdateCandidate { get; set; }
        public DeleteCandidateViewModel DeleteCandidate { get; set; }
        public List<MajorViewModel> AllMajor { get; set; } = new List<MajorViewModel>();
        public List<NationalityViewModel> Allnationality { get; set; } = new List<NationalityViewModel>();
        public List<CandidateStatusViewModel> AllStatus { get; set; } = new List<CandidateStatusViewModel>();
    }
}
