using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class UserController : Controller
    {
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;


        public UserController(IUserRepo userRepo, IRoleRepo roleRepo)
        {
            _userRepo = userRepo;
            _roleRepo = roleRepo;

        }

        //
        public IActionResult Index()
        {
            try
            {
                var users = _userRepo.GetUsers();
                if (users.IsValid)
                {
                    return View(users.Model);
                }



                return View(users.Model);

            }
            catch (Exception)
            {
                throw;

            }

        }
        public IActionResult Add()
        {
            try
            {
                var model = new AddUserViewModel
                {
                    Roles = _roleRepo.GetAllRoles()
                };
                return View(model);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel model)
        {

            _userRepo.AddUser(model);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            try
            {
                var user = _userRepo.GetById(id);
                var updateModel = new UpdateUserViewModel
                {
                    UserId = user.Model.UserId,
                    UserName = user.Model.UserName,
                    RoleId = user.Model.RoleId,
                    Roles = _roleRepo.GetAllRoles()
                };
                return View(updateModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");

            }

        }
        [HttpPost]
        public IActionResult EditUser(int userId, int roleId, string userName)
        {
            try
            {

                var userToUpdate = new UpdateUserViewModel();
                userToUpdate.UserName = userName;
                userToUpdate.UserId = userId;
                userToUpdate.RoleId = roleId;
                _userRepo.EditUser(userToUpdate);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {

            try
            {
                var userModel = _userRepo.GetById(id);
                if (userModel.IsValid)
                {

                    var userToDelete = new DeleteUserViewModel
                    {
                        UserId = userModel.Model.UserId,
                        UserName = userModel.Model.UserName,
                        RoleName = userModel.Model.RoleName,
                        IsActive = userModel.Model.IsActive
                    };
                    return View(userToDelete);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                var user = _userRepo.GetById(id);

                var userToDelte = new DeleteUserViewModel
                {
                    UserId = user.Model.UserId,
                    UserName = user.Model.UserName,
                    RoleName = user.Model.RoleName,
                    IsActive = user.Model.IsActive

                };
                _userRepo.DeleteUser(userToDelte);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
