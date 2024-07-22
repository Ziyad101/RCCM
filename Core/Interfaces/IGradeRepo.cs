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
    }
}
