using Core.Entities.ViewModel.CandidateExamSchedule;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class CandidateExamScheduleController : Controller
    {
        private readonly CandidateExamScheduleService _scheduleService;

        public CandidateExamScheduleController(CandidateExamScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
            
        }
        public IActionResult Index()
        {
            var models = _scheduleService.GetSchedules();
            return View(models);
        }

        public IActionResult ScheduleExam(int CandidateId = 0)
        {
            if (CandidateId > 0)
            {
                var model = _scheduleService.GetAddModel(CandidateId);
                return View(model);
            }

            else {
                var model = _scheduleService.GetAddModel();
                return View(model);
            }


        }
        [HttpGet]
        public IActionResult Add(AddCandidateExamScheduleViewModel model)
        {
            _scheduleService.AddExam(model);
            return RedirectToAction("Index");
        }
    }
}
