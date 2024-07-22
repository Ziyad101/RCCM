using Core.Entities.Generic;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUserRepo
    {
        public GenericResult<List<UserViewModel>> GetUsers();
        GenericResult<UserViewModel> GetById(int id);
        public void EditUser(UpdateUserViewModel updateUser);
        public void AddUser(AddUserViewModel user);
        public void DeleteUser(DeleteUserViewModel userModel);



    }

    ////
    ///





}
