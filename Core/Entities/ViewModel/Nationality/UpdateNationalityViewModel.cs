using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.ViewModel.Role;

namespace Core.Entities.ViewModel.Nationality
{
    public class UpdateNationalityViewModel
    {
        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
