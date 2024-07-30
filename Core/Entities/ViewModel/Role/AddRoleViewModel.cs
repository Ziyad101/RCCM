using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Role
{
    public class AddRoleViewModel
    {
        [Required(ErrorMessage ="نثقبلانتضثاقبن name is requuired")]
        [Display(Name =" اسم الصلاحية")]
        public string RoleName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
