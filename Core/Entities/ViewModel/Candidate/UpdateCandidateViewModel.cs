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
    public class UpdateCandidateViewModel
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string NationalId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public NationalityViewModel Nationality { get; set; }
        public MajorViewModel Major { get; set; }
        public List<NationalityViewModel> Nationalities { get; set; }
        public List<MajorViewModel> Majors { get; set; }
        public List<CandidateStatusViewModel> CandidateStatuses { get; set; }
        public CandidateStatusViewModel CandidateStatus { get; set; }
        public int CandidateStatusId { get; set; }
        public int MajorId { get; set; }
        public int NationalityId { get; set; }


    }
}
