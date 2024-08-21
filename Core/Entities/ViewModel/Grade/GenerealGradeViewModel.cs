using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Grade
{
    public class GenerealGradeViewModel
    {
        public List<GradeViewModel> AllGrade {  get; set; }
        public GradeViewModel SingleGrade { get; set; }
        public AddGradeViewModel AddGrade { get; set; }
        public UpdateGradeViewModel UpdateGrade { get; set; }
        public DeleteGradeViewModel DeleteGrade { get; set; }
    }
}
