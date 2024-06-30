using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Model
{
    public class CreatorExamTypeConf
    {
        [Key]
        public int AuditExamTypeConfId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("ExamTypeConf")]
        public int ExamTypeConfId { get; set; }
        public ExamTypeConf ExamTypeConf { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public bool IsActive { get; set; }



    }
}
