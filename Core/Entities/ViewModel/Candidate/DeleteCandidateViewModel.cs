using Core.Entities.ViewModel.Major;
using Core.Entities.ViewModel.Nationality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Candidate
{
    public class DeleteCandidateViewModel
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string NationalId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public NationalityViewModel Nationality {get; set;}
        public MajorViewModel Major {get; set;}
        public CandidateViewModel CandidateStatus { get; set; }
    }
}
