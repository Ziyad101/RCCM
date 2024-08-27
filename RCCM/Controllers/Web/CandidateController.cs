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
        private readonly CandidateService _candidateService;



        public CandidateController(CandidateService candidateService)
        {
            _candidateService = candidateService;
        }



        public IActionResult Index()
        {

            var model = _candidateService.GetGeneralCandidateModel();
            return View(model);
        }

        public IActionResult Add()
        {
            var candidateModel = _candidateService.GetAddModel();
            return View(candidateModel);
        }



        [HttpPost]
        public IActionResult Add(AddCandidateViewModel model)
        {
            _candidateService.AddCandidate(model);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            var model = _candidateService.GetUpdateModel(id);
            return View(model);
        }

        public IActionResult EditCandidate(UpdateCandidateViewModel updateModel)
        {
            _candidateService.UpdateCandidate(updateModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = _candidateService.GetDeleteModel(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteCandidate(DeleteCandidateViewModel model)
        {
            _candidateService.DeleteCandidate(model);
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
