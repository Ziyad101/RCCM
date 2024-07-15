using Core.Interfaces;
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
    }
}
