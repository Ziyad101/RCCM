using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Interview
{
    public class GeneralInterviewViewModel
    {
        public List<InterviewViewModel> AllInterview { get; set; }
        public InterviewViewModel SingleInterView { get; set; }
        public AddInterviewViewModel AddInterview { get; set; }
        public UpdateInterviewViewModel UpdateInterview { get; set; }
        public DeleteInterviewViewModel DeleteInterview { get; set; }
    }
}
