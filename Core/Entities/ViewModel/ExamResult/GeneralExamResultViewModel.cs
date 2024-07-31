using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.ExamResult
{
    public class GeneralExamResultViewModel
    {
        public List<ExamResultViewModel> AllExamResult { get; set; }
        public ExamResultViewModel SingleExamResult { get; set; }
        public AddExamResultViewModel AddExamResult { get; set; }
        public UpdateExamResultViewModel UpdateExamResult { get; set; }
        public DeleteExamResultViewModel DeleteExamResultViewModel { get; set; }
    }
}
