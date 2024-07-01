using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class InterviewResult
    {
        [Key]
        public int InterviewResultId { get; set; }
        public string Result { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Interview")]
        public int InterviewId { get; set; }
        public Interview Interview { get; set; }
    }
}
