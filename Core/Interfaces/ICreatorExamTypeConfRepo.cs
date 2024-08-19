using Core.Entities.ViewModel.CreatorExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICreatorExamTypeConfRepo
    {
        List<CreatorExamTypeConfViewModel> GetAllCreatorExam();
        CreatorExamTypeConfViewModel GetCreatorExamById(int id);
        void AddCreator(AddCreatorExamTypeConfViewModel creatorModel);
        void UpdateCreator(UpdateCreatorExamTypeConfViewModel creatorModel);
        void DeleteCreator(DeleteCreatorExamTypeConfViewModel creatorModel);
        UpdateCreatorExamTypeConfViewModel GetEditModel(int id);
        DeleteCreatorExamTypeConfViewModel GetDeleteModel(int id);
    }
}
