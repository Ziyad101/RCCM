using Core.Entities.ViewModel.Grade;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class GradeController : Controller
    {
        private readonly IGradeRepo _gradeRepo;
        public GradeController(IGradeRepo GradeRepo)
        {
            _gradeRepo = GradeRepo;
        }
        public IActionResult Index()
        {
            try
            {
                var GradeModels = _gradeRepo.GetAllGrades();
                return View(GradeModels);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public IActionResult Add()
        {
            return View();
        }

    }
}

