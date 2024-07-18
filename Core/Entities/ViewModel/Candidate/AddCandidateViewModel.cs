using Core.Entities.Model;
using Core.Entities.ViewModel.Major;
using Core.Entities.ViewModel.Nationality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Candidate
{
    public class AddCandidateViewModel
    {
        public string CandidateName { get; set; }
        public int NationalId { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int RequestStatus { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int MajorId { get; set; }
        public List<MajorViewModel> Majors { get; set; }
        public int NationalityId { get; set; }
        public List<NationalityViewModel> Nationalities { get; set; }
    }
}
