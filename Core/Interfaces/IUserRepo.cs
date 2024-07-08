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
        List<UserViewModel> GetUsers();
        UserViewModel GetById(int id);
        void EditUser(UpdateUserViewModel updateUser);
        void AddUser(AddUserViewModel user);
        void DeleteUser(DeleteUserViewModel userModel);
        UpdateUserViewModel GetEditModel(UserViewModel userModel);
        DeleteUserViewModel GetDeleteModel(UserViewModel userModel);


    }






}
