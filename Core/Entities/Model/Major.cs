using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class Major
    {
        [Key]
        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
