using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Grade
{
    public class UpdateGradeViewModel
    {
          public int GradeId { get; set; }
        public int GradeValue { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

       
   }
 }

