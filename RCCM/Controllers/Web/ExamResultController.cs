using Core.Entities.ViewModel.CandidateStatus;
using Core.Entities.ViewModel.ExamResult;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class ExamResultController : Controller
    {
        private readonly IExamResultRepo _examResultRepo;

        public ExamResultController(IExamResultRepo examResultRepo)
        {
            _examResultRepo = examResultRepo;
        }
        public IActionResult Index()
        {
            var models = _examResultRepo.GetAllExamResutls();
            return View(models);
        }

        public IActionResult Add()
        {
            return View(new AddCandidateStatusViewModel());
        }

        public IActionResult AddExamResult(AddExamResultViewModel model)
        {
            _examResultRepo.AddExamResult(model);   
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var model = _examResultRepo.GetEditModel(id);
            return View(model);
        }

        public IActionResult EditExamResult(UpdateExamResultViewModel model)
        {
            _examResultRepo.UpdateExamResult(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = _examResultRepo.GetDeleteModel(id);
            return View(model);

        }

        public IActionResult DeleteExamResult(DeleteExamResultViewModel model)
        {
            _examResultRepo.DeleteExamResult(model);
            return RedirectToAction("Index");
        }
    }
}
