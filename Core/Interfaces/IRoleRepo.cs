using Core.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Interfaces
{
    public interface IRoleRepo
    {
        IEnumerable<Role> GetAllRoles();
    }
}