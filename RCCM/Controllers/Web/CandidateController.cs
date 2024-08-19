using Core.Entities.ViewModel;
using Core.Entities.ViewModel.Candidate;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class CandidateController : Controller
    {
        private readonly ICandidateRepo _candidateRepo;
        private readonly IMajorRepo _majorRepo;
        private readonly INationalityRepo _nationalityRepo;
        private readonly ICandidateStatusRepo _candidateStatusRepo;

        public CandidateController(ICandidateRepo candidateRepo, IMajorRepo majorRepo, INationalityRepo nationalityRepo,ICandidateStatusRepo candidateStatus)
        {
            _candidateRepo = candidateRepo;
            _majorRepo = majorRepo;
            _nationalityRepo = nationalityRepo;
            _candidateStatusRepo = candidateStatus;
        }

 

        public IActionResult Index()
        {

            var viewModels = _candidateRepo.GetAllCandidate();
            var majors = _majorRepo.GetAllMajors();
            var nations= _nationalityRepo.GetAllNationalitys();
            var candidateStatuses = _candidateStatusRepo.GetAllCandidateStatus();
            var model = new GeneralCandidateViewModel();
            GeneralCandidateViewModel.AllMajors=majors;
            GeneralCandidateViewModel.AllNationalities =nations;
            GeneralCandidateViewModel.AllCandidateStatuses =candidateStatuses;
            model.AllCandidate = viewModels;
            model.PupulateModels();
            return View(model);
        }


        public IActionResult Add()
        {
            try
        {
                var candidateModel = new AddCandidateViewModel();
                candidateModel.Majors = _majorRepo.GetAllMajors();
                candidateModel.Nationalities = _nationalityRepo.GetAllNationalitys();
                candidateModel.CandidateStatuses = _candidateStatusRepo.GetAllCandidateStatus();
                return View(candidateModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Add(AddCandidateViewModel model)
        {
            _candidateRepo.AddCandidate(model);
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            var candidateUpdateModel = _candidateRepo.GetEditModel(id);
            candidateUpdateModel.Nationalities = _nationalityRepo.GetAllNationalitys();
            candidateUpdateModel.Majors = _majorRepo.GetAllMajors();
            candidateUpdateModel.CandidateStatuses = _candidateStatusRepo.GetAllCandidateStatus();
            return View(candidateUpdateModel);
        }

        public IActionResult EditCandidate(UpdateCandidateViewModel updateModel)
        {
            _candidateRepo.UpdateCandidate(updateModel);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
           var model = _candidateRepo.GetDeleteModel(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteCandidate(DeleteCandidateViewModel model)
        {
            _candidateRepo.DeleteCandidate(model);
            return RedirectToAction("Index");
        }

        public IActionResult CandidateIndex()
        {
            return View();
        }
    }


}
