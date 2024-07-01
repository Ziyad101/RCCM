using Core.Interfaces;
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
        [Route("login/a")]
        public IActionResult Index()
        {
            var userModel = _userRepo.GetUserViewModel();
            
            return View(userModel);
        }
        public IActionResult Dashboard()
        {
            return View();
        }

    }
}
