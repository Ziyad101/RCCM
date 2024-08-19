using Core.Entities.ViewModel.Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IInterviewRepo
    {
        List<InterviewViewModel> GetAllInterviews();
        InterviewViewModel GetInterviewById(int id);
        void AddInterview(AddInterviewViewModel interviewModel);
        void UpdateInterview(UpdateInterviewViewModel interviewModel);
        void DeleteInterview(DeleteInterviewViewModel interviewModel);
        UpdateInterviewViewModel GetEditModel(int id);
        DeleteInterviewViewModel GetDeleteModel(int id);

    }
}
