using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Grade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGradeRepo 
    {
        List<GradeViewModel> GetAllGrades();

        void AddGrade(AddGradeViewModel gradeModel);

        void DeleteGrade(DeleteGradeViewModel gradeModel);

        DeleteGradeViewModel GetDeleteModel(int id);

       void EditGrade(UpdateGradeViewModel gradeModel);

        UpdateGradeViewModel GetEditModel(int id); 
    }
}
