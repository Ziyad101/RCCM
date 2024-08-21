using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CreatorExamTypeConf
{
    public class GenerealCreatorExamTypeConfViewModel
    {
        public List<CreatorExamTypeConfViewModel> AllcreatorExamTypeConfViewModel { get; set; }
        public CreatorExamTypeConfViewModel SinglecreatorExamTypeConfViewModel { get; set; }
        public AddCreatorExamTypeConfViewModel AddCreatorExamTypeConfViewModel { get; set; }
        public UpdateCreatorExamTypeConfViewModel UpdateCreatorExamTypeConfViewModel { get;set; }
        public DeleteCreatorExamTypeConfViewModel DeleteCreatorExamTypeConfViewModel { get; set; }

    }
}
