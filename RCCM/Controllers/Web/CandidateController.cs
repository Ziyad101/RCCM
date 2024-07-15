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

        public CandidateController(ICandidateRepo candidateRepo)
        {
            _candidateRepo = candidateRepo;
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
                
                return View(new AddCandidateViewModel());
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
    }
}
