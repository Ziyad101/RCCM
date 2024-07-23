using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }

        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool ExperienceMatch { get; set; }
        public decimal Salary { get; set; }
        public decimal Benefits { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
