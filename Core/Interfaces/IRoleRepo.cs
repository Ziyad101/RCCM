using Core.Entities.Model;
using Core.Entities.ViewModel.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Interfaces
{
    public interface IRoleRepo
    {
        List<RoleViewModel> GetAllRoles();
        public RoleViewModel GetRoleById(int id);
        public void AddRole(AddRoleViewModel roleModel);
        public void DeleteRole(DeleteRoleViewModel roleModel);
        public void EditRole(UpdateRoleViewModel roleModel);
        public DeleteRoleViewModel GetDeleteModel(RoleViewModel roleModel);
        public UpdateRoleViewModel GetEditModel(RoleViewModel roleModel);

    }
}