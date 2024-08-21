using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.ExamTypeConf
{
    public class GenerealExamTypeConfViewModel
    {
        public List<ExamTypeConfViewModel> AllExamTypeConf { get; set; }
        public ExamTypeConfViewModel SingleExamTypeConf { get; set; }
        public AddExamTypeConfViewModel AddExamTypeConf { get; set; }
        public UpdateExamTypeConfViewModel UpdateExamTypeConf { get;set; }
        public DeleteExamTypeConfViewModel DeleteExamTypeConf { get; set; }
    }
}
