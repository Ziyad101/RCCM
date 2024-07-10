using Core.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
<<<<<<<< HEAD:Core/Entities/ViewModel/UserModels/UserViewModel.cs


========
>>>>>>>> 7bb83e2c6d26f77d6727530523aafe5081254d18:Core/Entities/ViewModel/User/UserViewModel.cs
        public int RoleId { get; set; }
        public string RoleName { get; set; }


    }


}
