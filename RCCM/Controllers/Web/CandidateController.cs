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

        public CandidateController(ICandidateRepo candidateRepo, IMajorRepo majorRepo)
        {
            _candidateRepo = candidateRepo;
            _majorRepo = majorRepo;
        }

 

        public IActionResult Index()
        {
            var viewModels = _candidateRepo.GetAllCandidate();
            return View(viewModels);
        }


        public IActionResult Add()
        {
            try
        {
                var candidateModel = new AddCandidateViewModel();
                candidateModel.Majors = _majorRepo.GetAllMajors();
                return View(candidateModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel model)
        {
           
            return RedirectToAction("Index");

        }

        public IActionResult CandidateIndex()
        {
            return View();
        }

    }


}
