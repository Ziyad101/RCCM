using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IExamTypeConfRepo
    {
        List<ExamTypeConfViewModel> GetAllExamTypeConf();
        ExamTypeConfViewModel GetExamTypeConfById(int id);
        void AddExamTypeConf(AddExamTypeConfViewModel examTypeConfModel);
        void UpdateExamTypeConf(UpdateExamTypeConfViewModel examTypeConfModel);
        void DeleteExamTypeConf(DeleteExamTypeConfViewModel examTypeConfModel);
        UpdateExamTypeConfViewModel GetEditModel(int id);
        DeleteExamTypeConfViewModel GetDeleteModel(int id);

    }
}
