using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public int RequestStatus { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }

}
