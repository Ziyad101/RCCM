using AutoMapper;
using Core.Entities.Generic;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;





namespace Infrastructure.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenericResult<UserViewModel> GetById(int id)
        {
            try
            {
                var user = _context.User.Include(u => u.Role).Where(x => x.UserId == id).FirstOrDefault();

                if (user == null)
                    return GenericResult<UserViewModel>.Fail();

                var userViewModel = _mapper.Map<UserViewModel>(user);



                return GenericResult<UserViewModel>.Success(userViewModel);

            }
            catch (Exception)
            {

                return GenericResult<UserViewModel>.Fail();
            }

        }

        public GenericResult<List<UserViewModel>> GetUsers()
        {
            try
            {
                var UserViewModels = new List<UserViewModel>();


                var users = _context.User.Include(x => x.Role).Where(u => u.IsActive).ToList();

                if (users.Count == 0)
                    return GenericResult<List<UserViewModel>>.Fail();


                foreach (var user in users)
                {
                    var userViewModel = _mapper.Map<UserViewModel>(user);

                    UserViewModels.Add(userViewModel);
                }

                return GenericResult<List<UserViewModel>>.Success(UserViewModels);
            }
            catch (Exception)
            {

                return GenericResult<List<UserViewModel>>.Fail();
            }
        }




        public void AddUser(AddUserViewModel user)
        {
            var addUser = _mapper.Map<User>(user);
            _context.User.Add(addUser);
            _context.SaveChanges();
        }

        public void EditUser(UpdateUserViewModel updateUser)
        {
            var user = _mapper.Map<User>(updateUser);
            _context.User.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(DeleteUserViewModel userModel)
        {
            var userToDelete = _mapper.Map<User>(userModel);
            userToDelete.IsActive = false;
            _context.Update(userToDelete);
            _context.SaveChanges();

        }
    }
}
