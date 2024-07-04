using AutoMapper;
using Core.Entities.Generic;
using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;



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

        public  GenericResult<UserViewModel> GetById(int id)
        {
            try
            {
                var user = _context.User.Include(u => u.Role).Where(x => x.UserId == id ).FirstOrDefault();
                
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

        public List<UserViewModel> GetUsers()
        {
            var UserViewModels = new List<UserViewModel>();
            

            var users = _context.User.Include(x=>x.Role).ToList();
            
            foreach (var user in users)
            {
                var userViewModel = _mapper.Map<UserViewModel>(user);
                
                UserViewModels.Add(userViewModel);
            }

            return UserViewModels;
        }

        public bool DeleteUser(int id)
        {
            try
            {
                var user = _context.User.Find(id);
                if (user == null)
                    return false;

                _context.User.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
      
        }


    }

