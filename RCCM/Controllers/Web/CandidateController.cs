using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Candidate;
using Core.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class CandidateController : Controller
    {
        private readonly ICandidateRepo _candidateRepo;
        private readonly CandidateService _candidateService;
      

        public CandidateController(ICandidateRepo candidateRepo,CandidateService candidateService)
        {
            _candidateRepo = candidateRepo;
            _candidateService = candidateService;
           
        }
        public IActionResult Index()
        {
            var model = _candidateService.GetGeneralModel();
            return View(model);
        }



        [HttpPost]
        public IActionResult Add(AddCandidateViewModel model)
        {
            _candidateRepo.AddCandidate(model);
            return RedirectToAction("Index");

        }

        public IActionResult EditCandidate(UpdateCandidateViewModel updateModel)
        {
            _candidateRepo.UpdateCandidate(updateModel);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult DeleteCandidate(DeleteCandidateViewModel model)
        {
            _candidateRepo.DeleteCandidate(model);
            return RedirectToAction("Index");
        }
    }
}
