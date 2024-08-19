using Core.Entities.ViewModel.Candidate;
using Core.Entities.ViewModel.Grade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Experience
{
    public class AddExperienceViewModel
    {
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool ExperienceMatch { get; set; }
        public decimal Salary { get; set; }
        public decimal Benefits { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int CandidateId { get; set; }
        public CandidateViewModel Candidate { get; set; }
        public int GradeId { get; set; }
        public GradeViewModel Grade { get; set; }
        public List<GradeViewModel> Grades { get; set; }
    }
}
