using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.ExamTypeConf
{
    public class UpdateExamTypeConfViewModel
    {
        public int ExamTypeConfId { get; set; }
        public string Title { get; set; }
        public bool Required { get; set; }
        public int PassGrade { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
