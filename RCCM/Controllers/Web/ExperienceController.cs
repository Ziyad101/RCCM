using Core.Entities.ViewModel.Experience;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class ExperienceController : Controller
    {
        private readonly ExperienceService _experienceService;

        public ExperienceController(ExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        
        public IActionResult Index()
        {
            var models = _experienceService.GetAllExperience();
            return View(models);
        }

        [HttpPost]
        public IActionResult Add(int CandidateId)
        {
            var model = _experienceService.GetAddModel(CandidateId);
            return View(model);
        }
        [HttpPost]
        public IActionResult AddExp(AddExperienceViewModel model)
        {
            _experienceService.AddExperience(model);
            return RedirectToAction("Index");
        }
    }
}
