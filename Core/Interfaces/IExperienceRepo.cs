using Core.Entities.ViewModel.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IExperienceRepo
    {
        List<ExperienceViewModel> GetAllExperiences();
        ExperienceViewModel GetExperienceById(int id);
        void AddExperience(AddExperienceViewModel experience);
        void UpdateExperience(UpdateExperienceViewModel experience);
        void DeleteExperience(DeleteExperienceViewModel experience);
        UpdateExperienceViewModel GetEditModel(int id);
        DeleteExperienceViewModel GetDeleteModel(int id);
    }
}
