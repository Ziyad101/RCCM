using Core.Entities.Model;
using Core.Entities.ViewModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Nationality
{
    public class NationalityViewModel
    {
        public int NationalityId { get; set; }

        public string NationalityName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
