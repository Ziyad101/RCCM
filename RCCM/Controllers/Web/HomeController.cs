using Core.Entities.ViewModel;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            
        }

        public IActionResult Index()
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



        public IActionResult Recruitment()
        {
            return View();
        }
        public IActionResult Candidate()
        {
            return View();
        }

        public IActionResult Interview()
        {
            return View();
        }

        public IActionResult CandTestTable()
        {
            return View();
        }

        public IActionResult InterviewTable()
        {
            return View();
        }


    }
}
