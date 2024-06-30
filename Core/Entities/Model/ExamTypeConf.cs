using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Core.Entities.Model
{
    public class ExamTypeConf
    {
        [Key]
        public int ExamTypeConfId { get; set; }
        public string Title { get; set; }
        public bool Required { get; set; }
        public int PassGrade { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        
        public List<ExamResult> ExamResults { get; set; }

        public List<CreatorExamTypeConf> CreatorExamTypeConf { get; set; }

    }
    
}
