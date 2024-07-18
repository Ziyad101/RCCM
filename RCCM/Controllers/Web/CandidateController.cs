using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class CandidateController : Controller
    {
        public IActionResult CandidateIndex()
        {
            return View();
        }

        public IActionResult AddCandidate()
        {
            return View();
        }
    }
}
