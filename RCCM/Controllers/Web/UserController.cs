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
                return View(users);
            }
            catch (Exception)
            {
                throw;

            }

        }

        public IActionResult Details(int id)
        {
            try
            {
                var userModel = _userRepo.GetById(id);

                if (!userModel.IsValid)
                {
                    return NotFound();
                }

                return View(userModel.Model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /////







        public IActionResult Add()
        {
            var model = new AddUserViewModel
            {
                Roles = _roleRepo.GetAllRoles() // Assuming GetAllRoles returns a list of roles
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.UserName,
                    RoleId = model.RoleId
                };
                _userRepo.AddUser(user);
                return RedirectToAction("Index");
            }

            // If the model state is not valid, repopulate the roles
            model.Roles = _roleRepo.GetAllRoles();
            return View(model);
        }






    }
}
