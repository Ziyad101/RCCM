using Core.Entities.ViewModel.CandidateStatus;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class CandidateStatusController : Controller
    {

        private readonly ICandidateStatusRepo _candidateStatusRepo;

        public CandidateStatusController(ICandidateStatusRepo candidateStatusRepo)
        {
            _candidateStatusRepo = candidateStatusRepo;
        }
        public IActionResult Index()
        {
            var models = _candidateStatusRepo.GetAllCandidateStatus();
            return View(models);
        }

        public IActionResult Add()
        {
            return View(new AddCandidateStatusViewModel());
        }

        public IActionResult AddCandidateStatus(AddCandidateStatusViewModel model)
        {
            _candidateStatusRepo.AddCandidateStatus(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var model = _candidateStatusRepo.GetEditModel(id);
            return View(model);
        }

        public IActionResult EditCandidateStatus(UpdateCandidateStatusViewModel model)
        {
            _candidateStatusRepo.UpdateCandidateStatus(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = _candidateStatusRepo.GetDeleteModel(id);
            return View(model);

        }

        public IActionResult DeleteCandidateStatus(DeleteCandidateStatusViewModel model)
        {
            _candidateStatusRepo.DeleteCandidateStatus(model);
            return RedirectToAction("Index");
        }
    }
}
