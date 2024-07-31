using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.Role
{
    public class GeneralRoleViewModel
    {
        public List<RoleViewModel> AllRole { get; set; }
        public RoleViewModel SingleRole { get; set; }
        public AddRoleViewModel AddRole { get; set; }
        public UpdateRoleViewModel UpdateRole { get; set; }
        public DeleteRoleViewModel DeleteRole { get; set; }
    }
}
