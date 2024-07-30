using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.ExamResult
{
    public class UpdateExamResultViewModel
    {
        public int ExamResultId { get; set; }
        public string Notes { get; set; }
        public bool PassedExam { get; set; }
        public DateTime ResultDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int ExamTypeConfId { get; set; }
        List<ExamTypeConfViewModel> ExamTypes { get; set; }
    }
}
