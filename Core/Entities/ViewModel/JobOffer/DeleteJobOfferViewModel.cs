using Core.Entities.ViewModel.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.JobOffer
{
    public class DeleteJobOfferViewModel
    {
        public int JobOfferId { get; set; }
        public string City { get; set; }
        public string Section { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public string JobTitle { get; set; }
        public byte[] Document { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public CandidateViewModel Candidate { get; set; }
    }
}
