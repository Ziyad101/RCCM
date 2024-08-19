using Core.Entities.ViewModel.CandidateExamSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICandidateExamScheduleRepo
    {
        List<CandidateExamScheduleViewModel> GetAllScheduledExams();
        CandidateExamScheduleViewModel GetCandidateExamScheduleById(int id);
        void AddScheduledExam(AddCandidateExamScheduleViewModel addModel);
        void UpdateScheduledExam(UpdateCandidateExamScheduleViewModel updateModel);
        void DeleteScheduledExam(DeleteCandidateExamScheduleViewModel deleteModel);
        UpdateCandidateExamScheduleViewModel GetUpdateModel(int id);
        DeleteCandidateExamScheduleViewModel GetDeleteModel(int id);
    }
}
