using Core.Entities.ViewModel.Major;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class MajorController : Controller
    {
        private readonly IMajorRepo _majorRepo;

        public MajorController(IMajorRepo majorRepo)
        {
            _majorRepo = majorRepo;
        }
        public IActionResult Index()
        {
            var majors = _majorRepo.GetAllMajors();
            return View(majors);
        }

        public IActionResult Add()
        {
            return View(new AddMajorViewModel());
        }

        [HttpPost]
        public IActionResult Add(AddMajorViewModel majorModel)
        {
            _majorRepo.AddMajor(majorModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            var majorModel = _majorRepo.GetEditModel(id);
            return View(majorModel);
        }

        [HttpPost]
        public IActionResult EditMajor(UpdateMajorViewModel majorModel)
        {
            _majorRepo.UpdateMajor(majorModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var majorModel = _majorRepo.GetDeleteModel(id);
            return View(majorModel);
        }

        [HttpPost]
        public IActionResult DeleteMajor(DeleteMajorViewModel majorModel)
        {

            _majorRepo.DeleteMajor(majorModel);
            return RedirectToAction("Index");
        }
    }


}
