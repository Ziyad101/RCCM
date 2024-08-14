using Core.Entities.Model;
using Core.Entities.ViewModel.Nationality;
using Core.Entities.ViewModel.Major;
using Core.Entities.ViewModel.CandidateStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.ViewModel.Request;

namespace Core.Entities.ViewModel.Candidate
{
    public class CandidateViewModel
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
        public CandidateStatusViewModel CandidateStatus {get; set;}
        public RequestViewModel Request {get; set;}


    }
}
