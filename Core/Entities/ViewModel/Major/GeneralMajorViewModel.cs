using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Major
{
    public class GeneralMajorViewModel
    {
        public List<MajorViewModel> AllMajor {  get; set; }
        public MajorViewModel SingleMajor { get; set; }
        public AddMajorViewModel AddMajor { get; set; }
        public UpdateMajorViewModel UpdateMajor { get; set; }
        public DeleteMajorViewModel DeleteMajor { get; set; }
    }
}
