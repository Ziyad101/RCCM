using Core.Entities.Model;
using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Nationality;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace RCCM.Controllers.Web
{
    public class NationalityController : Controller
    {

        private readonly INationalityRepo _nationalityRepo;

        public NationalityController(INationalityRepo nationalityRepo)
        {
            _nationalityRepo = nationalityRepo;
        }

        public IActionResult Index()
        {
            try
            {
                var nationality = _nationalityRepo.GetAllNationalitys();

                return View(nationality);

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
                var model = new AddNationalityViewModel();
                return View(model);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Add(AddNationalityViewModel model)
        {
            _nationalityRepo.AddNationality(model);
            return RedirectToAction("Index");

        }




        [HttpPost]
        public IActionResult Edit(int id)
        {
            try
            {
                var nationality = _nationalityRepo.GetById(id);
                var updateModel = _nationalityRepo.GetEditModel(nationality);
                return View(updateModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");

            }

        }



        [HttpPost]
        public IActionResult EditNationality(UpdateNationalityViewModel nationalitModel)
        {
            try
            {
                _nationalityRepo.EditNationality(nationalitModel);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }



        public IActionResult Delete(int id)
        {

            try
            {
                var nationalityModel = _nationalityRepo.GetById(id);
                var nationalityToDelete = _nationalityRepo.GetDeleteModel(nationalityModel);
                return View(nationalityToDelete);

            }
            catch (Exception)
            {
                RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult DeleteNationality(int id)
        {
            try
            {
                var nationality = _nationalityRepo.GetById(id);

                var nationalityToDelete = _nationalityRepo.GetDeleteModel(nationality);
                _nationalityRepo.DeleteNationality(nationalityToDelete);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }


   








}
