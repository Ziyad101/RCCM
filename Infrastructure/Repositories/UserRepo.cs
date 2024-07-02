using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Interfaces;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            this._context = context;
        }

        

        public UserViewModel GetById(int id)
        {
            var userViewModel = new UserViewModel();
            User user = _context.User.Include(u => u.Role).FirstOrDefault(u => u.UserId == id);
            userViewModel.UserName = user.UserName;
            if (user.Role != null)
            {
                userViewModel.UserRole = user.Role.RoleName;
                userViewModel.Role = user.Role;
            }
            return userViewModel;
        }

        public List<UserViewModel> GetUsers()
        {
            var UserViewModels = new List<UserViewModel>();
            var users = _context.User.Include(u => u.Role).ToList();
            
            foreach (var user in users)
            {
                UserViewModel userViewModel = new UserViewModel();
                userViewModel.UserName = user.UserName;
                if (user.Role != null)
                {
                    userViewModel.UserRole = user.Role.RoleName;
                    userViewModel.Role = user.Role;
                }
                UserViewModels.Add(userViewModel);
            }

            return UserViewModels;
        }


    }
}
