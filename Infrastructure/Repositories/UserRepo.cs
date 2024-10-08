﻿using AutoMapper;
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

        public UserViewModel GetUserById(int id)
        {
            try
            {
                var user = _context.User.Include(u => u.Role).AsNoTracking().Where(x => x.UserId == id).FirstOrDefault();

                var userViewModel = _mapper.Map<UserViewModel>(user);

                return userViewModel;

            }
            catch (Exception)
            {

                return new UserViewModel();
            }

        }

        public List<UserViewModel> GetAllUsers()
        {
            try
            {
                var users = _context.User.Include(x => x.Role).AsNoTracking().Where(u => u.IsActive).ToList();

                var UserViewModels = _mapper.Map<List<UserViewModel>>(users);

                return UserViewModels;
            }
            catch (Exception)
            {

                return new List<UserViewModel>();
            }
        }




        public void AddUser(AddUserViewModel user)
        {

            var addUser = _mapper.Map<User>(user);

            _context.User.Add(addUser);
            SaveChanges();
        }

        public void EditUser(UpdateUserViewModel updateUser)
        {
            var user = _mapper.Map<User>(updateUser);
            _context.User.Update(user);
            SaveChanges();
        }

        public void DeleteUser(DeleteUserViewModel userModel)
        {
            var userToDelete = _mapper.Map<User>(userModel);
            userToDelete.IsActive = false;
            _context.Update(userToDelete);
            SaveChanges();


        }

        public UpdateUserViewModel GetEditModel(int id)
        {
            var userModel = GetUserById(id);
            UpdateUserViewModel model = _mapper.Map<UpdateUserViewModel>(userModel);
            return model;

        }

        public DeleteUserViewModel GetDeleteModel(int id)
        {
            var userModel = GetUserById(id);
            DeleteUserViewModel model = _mapper.Map<DeleteUserViewModel>(userModel);

            return model;
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
