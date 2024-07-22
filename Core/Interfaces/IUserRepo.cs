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
        List<UserViewModel> GetAllUsers();
        UserViewModel GetUserById(int id);
        void EditUser(UpdateUserViewModel userModel);
        void AddUser(AddUserViewModel user);
        void DeleteUser(DeleteUserViewModel userModel);
        UpdateUserViewModel GetEditModel(int id);
        DeleteUserViewModel GetDeleteModel(int id);




    }

    ////
    ///





}
