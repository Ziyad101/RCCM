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

        public IActionResult Index()
        {
            try
            {
                var users = _userRepo.GetAllUsers();
                return View(users);

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
                var model = new AddUserViewModel();
                model.Roles = _roleRepo.GetAllRoles();
                return View(model);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel userModel)
        {
            _userRepo.AddUser(userModel);
            return RedirectToAction("Index");

        }



        [HttpPost]
        public IActionResult Edit(int id)
        {
            try
            {
               
                var updateModel = _userRepo.GetEditModel(id);
                updateModel.Roles = _roleRepo.GetAllRoles();
                return View(updateModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");

            }

        }
        [HttpPost]
        public IActionResult EditUser(UpdateUserViewModel userModel)
        {
            try
            {
                _userRepo.EditUser(userModel);
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
               var userToDelete = _userRepo.GetDeleteModel(id);
                return View(userToDelete);

            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult DeleteUser(DeleteUserViewModel userModel)
        {
            try
            {
                _userRepo.DeleteUser(userModel);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
