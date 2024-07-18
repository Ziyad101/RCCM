using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class InterviewController : Controller
    {
        public IActionResult InterviewIndex()
        {
            return View();
        }

        public IActionResult InterviewTable()
        {
            return View();
        }
    }
}
