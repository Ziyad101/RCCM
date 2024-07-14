using Core.Entities.Model;
using Core.Entities.ViewModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel
{
    public class AddNationalityViewModel
    {
   
        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
        public bool IsActive { get; set; } = true;
        
      
    }

}
