using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Major
{
    public class DeleteMajorViewModel
    {
        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
