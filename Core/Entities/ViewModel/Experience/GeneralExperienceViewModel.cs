using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Experience
{
    public class GeneralExperienceViewModel
    {
        public List<ExperienceViewModel> AllExperience { get; set; }
        public ExperienceViewModel SingleExperience { get; set; }
        public AddExperienceViewModel AddExperience { get; set; }
        public UpdateExperienceViewModel UpdateExperience { get; set; }
        public DeleteExperienceViewModel DeleteExperience { get; set; }
    }
}
