using Core.Entities.ViewModel.ExamResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IExamResultRepo
    {
        List<ExamResultViewModel> GetAllExamResutls();
        ExamResultViewModel GetExamResultById(int id);
        void AddExamResult(AddExamResultViewModel addModel);
        void UpdateExamResult(UpdateExamResultViewModel updateModel);
        void DeleteExamResult(DeleteExamResultViewModel deleteModel);
        UpdateExamResultViewModel GetEditModel(int id);
        DeleteExamResultViewModel GetDeleteModel(int id);

    }
}
