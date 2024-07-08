using Core.Entities.Model;
using Core.Entities.ViewModel;
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
    }
}