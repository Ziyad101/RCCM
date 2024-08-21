using Core.Entities.ViewModel.Grade;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace RCCM.Controllers.Web
{

    public class GradeController : Controller
    {
        private readonly IGradeRepo _gradeRepo;
        public GradeController(IGradeRepo GradeRepo)
        {
            _gradeRepo = GradeRepo;
        }

        //this function to show the info in ViewModel

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

            return View(new AddGradeViewModel());
        }
        //this function to save the data in database
        [HttpPost]
        public IActionResult AddGrade(AddGradeViewModel gradeModel)
        {

            _gradeRepo.AddGrade(gradeModel);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var gradeToDelete = _gradeRepo.GetDeleteModel(id);
                return View(gradeToDelete);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPost]
        public IActionResult DeleteGrade(DeleteGradeViewModel gradeModel)
        {
            try
            {
                _gradeRepo.DeleteGrade(gradeModel);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            try
            {
                var updateModel = _gradeRepo.GetEditModel(id);
                return View(updateModel);

            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public IActionResult EditGrade(UpdateGradeViewModel gradeModel)
        {
            try
            {
                _gradeRepo.EditGrade(gradeModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}


