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
        private readonly IMajorRepo _majorRepo;
        private readonly INationalityRepo _nationalityRepo;
        private readonly ICandidateStatusRepo _candidateStatus;


        public CandidateController(ICandidateRepo candidateRepo, CandidateService candidateService, IMajorRepo majorRepo, INationalityRepo nationalityRepo, ICandidateStatusRepo candidateStatus)
        {
            _candidateRepo = candidateRepo;
            _majorRepo = majorRepo;
            _nationalityRepo = nationalityRepo;
            _candidateStatus = candidateStatus;
        }
        public IActionResult Index()
        {
            var model = _candidateRepo.GetAllCandidate();
            return View(model);
        }

        public IActionResult Add()
        {
            var model = new AddCandidateViewModel();
            model.Majors = _majorRepo.GetAllMajors();
            model.CandidateStatuses = _candidateStatus.GetAllCandidateStatus();
            model.Nationalities = _nationalityRepo.GetAllNationalitys();
            return View(model);
        }



        [HttpPost]
        public IActionResult Add(AddCandidateViewModel model)
        {
            _candidateRepo.AddCandidate(model);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            var model = _candidateRepo.GetEditModel(id);
            model.Majors = _majorRepo.GetAllMajors();
            model.CandidateStatuses = _candidateStatus.GetAllCandidateStatus();
            model.Nationalities = _nationalityRepo.GetAllNationalitys();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id) 
        { 
            var model = _candidateRepo.GetDeleteModel(id);
            return View(model);
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
