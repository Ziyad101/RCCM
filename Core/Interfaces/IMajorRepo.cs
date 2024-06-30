using Core.Entities.ViewModel.Major;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMajorRepo
    {
        List<MajorViewModel> GetAllMajors();
        MajorViewModel GetMajorById(int majorId);
        void AddMajor(AddMajorViewModel majorModel);
        void DeleteMajor(DeleteMajorViewModel majorModel);
        void UpdateMajor(UpdateMajorViewModel majorModel);
        UpdateMajorViewModel GetEditModel(int id);
        DeleteMajorViewModel GetDeleteModel(int id);
    }
}
