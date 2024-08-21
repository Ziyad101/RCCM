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

            var viewModels = _candidateRepo.GetAllCandidate();
            var majors = _majorRepo.GetAllMajors();
            var nations = _nationalityRepo.GetAllNationalitys();
            var candidateStatuses = _candidateStatus.GetAllCandidateStatus();
            var model = new GeneralCandidateViewModel();
            GeneralCandidateViewModel.AllMajors = majors;
            GeneralCandidateViewModel.AllNationalities = nations;
            GeneralCandidateViewModel.AllCandidateStatuses = candidateStatuses;
            model.AllCandidate = viewModels;
            model.PupulateModels();
            return View(model);
        }

        public IActionResult Add()
        {

            var candidateModel = new AddCandidateViewModel();
            candidateModel.Majors = _majorRepo.GetAllMajors();
            candidateModel.Nationalities = _nationalityRepo.GetAllNationalitys();
            candidateModel.CandidateStatuses = _candidateStatus.GetAllCandidateStatus();
            return View(candidateModel);
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

        [HttpPost]
        public IActionResult AddExp(int candidateId, string candidateName)
        {
            try
            {
                var viewModel = new UpdateCandidateViewModel
                {
                    CandidateId = candidateId,
                    CandidateName = candidateName
                };
                return View("UpdateCandidatePage", viewModel);
            }
            catch (Exception ex)
            {
                // Log the error (consider using a logging framework)
                Console.WriteLine($"Error: {ex.Message}");
                return View("Error"); // Ensure you have an Error view
            }
        }


    }


}
