using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CreatorExamTypeConf
{
    public class AddCreatorExamTypeConfViewModel
    {
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
        public int ExamTypeConfId { get; set; }
        public ExamTypeConfViewModel ExamType { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
