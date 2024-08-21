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

        public List<CandidateViewModel> AllCandidate { get; set; }
        public CandidateViewModel SingleCandidate { get; set; }
        public AddCandidateViewModel AddCandidate { get; set; } = new AddCandidateViewModel();
        public UpdateCandidateViewModel UpdateCandidate { get; set; } = new UpdateCandidateViewModel();
        public DeleteCandidateViewModel DeleteCandidate { get; set; } = new DeleteCandidateViewModel();
        public static List<MajorViewModel> AllMajors { get; set; }
        public static List<NationalityViewModel > AllNationalities { get; set; }
        public static List<CandidateStatusViewModel > AllCandidateStatuses { get; set; }

        public void PupulateModels()
        {
            AddCandidate.Majors = AllMajors;
            AddCandidate.Nationalities = AllNationalities;
            AddCandidate.CandidateStatuses = AllCandidateStatuses;
            UpdateCandidate.Majors = AllMajors;
            UpdateCandidate.Nationalities = AllNationalities;
            UpdateCandidate.CandidateStatuses = AllCandidateStatuses;
        }
       
    }
}
