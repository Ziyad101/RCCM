using Core.Entities.ViewModel.Interview;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class InterviewController : Controller
    {
        private readonly IInterviewRepo _interviewRepo;
        private readonly ICandidateRepo _candidateRepo;

        public InterviewController(IInterviewRepo interviewRepo, ICandidateRepo candidateRepo)
        {
            _interviewRepo = interviewRepo;
            _candidateRepo = candidateRepo;
        }
        public IActionResult Index()
        {
            var models = _interviewRepo.GetAllInterviews();
            return View(models);
        }
        public IActionResult Add()
        {
            var model = new AddInterviewViewModel();
            model.Candidates = _candidateRepo.GetAllCandidate();
            return View(model);
        }

        public IActionResult AddInterview(AddInterviewViewModel model)
        {
            _interviewRepo.AddInterview(model);
            return RedirectToAction("Index");
        }
       
        public IActionResult Edit(int id)
        {
            var model = _interviewRepo.GetEditModel(id);
            model.Candidates = _candidateRepo.GetAllCandidate();
            return View(model);
        }

        public IActionResult EditInterview(UpdateInterviewViewModel model)
        {
            _interviewRepo.UpdateInterview(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = _interviewRepo.GetDeleteModel(id);
            return View(model);
        }

        public IActionResult DeleteInterview(DeleteInterviewViewModel model)
        {
            _interviewRepo.DeleteInterview(model);
            return RedirectToAction("Index");
        }

        public IActionResult InterviewIndex()
        {
            return View();
        }

        public IActionResult InterviewTable()
        {
            return View();
        }

    }
}
