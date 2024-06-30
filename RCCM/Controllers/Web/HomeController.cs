using Core.Entities.ViewModel;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepo _homeRepo;

        public HomeController(IHomeRepo homeRepo)
        {
            _homeRepo = homeRepo;
        }

        public IActionResult Index()
        {
            try
            {
                var DemoViewModel = _homeRepo.getViewModeltest();

                return View(DemoViewModel);

            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]
        public IActionResult settest(DemoViewModel viewModel)
        {
            try
            {
                return RedirectToAction(nameof(Details), "Home");

            }
            catch (Exception)
            {

                throw;
            }

        }


        public IActionResult Details()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
