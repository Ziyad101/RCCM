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
        public List<UserViewModel> GetUsers();
        GenericResult<UserViewModel> GetById(int id);
       



        //
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
        void AddUser(User user);

       /* void UpdateUser(User user);
        void DeleteUser(int userId);
       */
    }
}
