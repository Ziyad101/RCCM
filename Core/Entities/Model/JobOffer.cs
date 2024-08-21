using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class JobOffer
    {
        [Key]
        public int JobOfferId { get; set; }
        public string City { get; set; }
        public string Section { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public string JobTitle { get; set; }
        public byte[] Document { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}
