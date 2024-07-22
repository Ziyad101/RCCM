using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
