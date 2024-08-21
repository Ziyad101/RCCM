using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel.User
{
    public class GeneralUserViewModel
    {
        public List<UserViewModel> AllUser { get; set; }
        public UserViewModel SingleUser { get; set; }
        public AddUserViewModel AddUser { get; set; }
        public UpdateUserViewModel UpdateUser { get; set; }
        public DeleteUserViewModel DeleteUser { get; set; }
    }
}
