using Core.Entities.ViewModel.CandidateStatus;
using Core.Entities.ViewModel.ExamResult;
using Core.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class ExamResultController : Controller
    {
        private readonly ExamResultService _examResultService;
        private readonly IExamResultRepo _examResultRepo;

        public ExamResultController(IExamResultRepo examResultRepo,ExamResultService examResultService)
        {
            _examResultRepo = examResultRepo;
            _examResultService = examResultService;

        }
        public IActionResult Index()
        {
            var models = _examResultService.GetAllExamResults();
            return View(models);
        }

        public IActionResult Add(int CandidateId,int ExamTypeConfId)
        {
            var model = _examResultService.GetAddModel(CandidateId,ExamTypeConfId);
            return View(model);
        }


        [HttpPost]
        public IActionResult AddExamResult(AddExamResultViewModel model)
        {
            _examResultService.AddExamResult(model);   
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
