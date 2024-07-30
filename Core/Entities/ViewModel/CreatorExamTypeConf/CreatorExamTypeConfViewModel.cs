using Core.Entities.Model;
using Core.Entities.ViewModel.ExamTypeConf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.CreatorExamTypeConf
{
    public class CreatorExamTypeConfViewModel
    {
        public int AuditExamTypeConfId { get; set; }
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
        public int ExamTypeConfId { get; set; }
        public ExamTypeConfViewModel ExamType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
