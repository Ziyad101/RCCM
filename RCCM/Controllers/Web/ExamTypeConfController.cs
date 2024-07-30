using Core.Entities.ViewModel.CandidateStatus;
using Core.Entities.ViewModel.ExamTypeConf;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class ExamTypeConfController : Controller
    {
        private readonly IExamTypeConfRepo _examTypeConfRepo;

        public ExamTypeConfController(IExamTypeConfRepo examTypeConfRepo)
        {
            _examTypeConfRepo = examTypeConfRepo;
        }
        public IActionResult Index()
        {
            var models = _examTypeConfRepo.GetAllExamTypeConf();
            return View(models);
        }

        public IActionResult Add()
        {
            return View(new AddExamTypeConfViewModel());
        }

        public IActionResult AddExamTypeConf(AddExamTypeConfViewModel model)
        {
            _examTypeConfRepo.AddExamTypeConf(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var model = _examTypeConfRepo.GetEditModel(id);
            return View(model);
        }

        public IActionResult EditExamTypeConf(UpdateExamTypeConfViewModel model)
        {
            _examTypeConfRepo.UpdateExamTypeConf(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = _examTypeConfRepo.GetDeleteModel(id);
            return View(model);

        }

        public IActionResult DeleteExamTypeConf(DeleteExamTypeConfViewModel model)
        {
            _examTypeConfRepo.DeleteExamTypeConf(model);
            return RedirectToAction("Index");
        }
    }
}
