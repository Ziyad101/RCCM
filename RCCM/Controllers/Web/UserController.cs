using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class UserController : Controller
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
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

        public IActionResult Update(int id)
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
        [HttpPost]
        public IActionResult UpdateUser(string UserName,int RoleId,int UserId)
        {
            var updateUserViewModel = new UpdateUserViewModel();
            updateUserViewModel.UserName = UserName;
            updateUserViewModel.UserId = UserId;
            updateUserViewModel.RoleId = RoleId;
            if (_userRepo.UpdateUser(updateUserViewModel))
            {
                return RedirectToAction("Index");
            }
            return NotFound();
        }


        /////


       

        public IActionResult Add()
        {
            return View();
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
            return View(model);
        }








    }
}
