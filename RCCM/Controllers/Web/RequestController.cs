using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace RCCM.Controllers.Web
{
    public class RequestController : Controller
    {
        private readonly IRequestRepo _requestRepo;

        public RequestController(IRequestRepo requestRepo)
        {
            _requestRepo = requestRepo;
        }
        public IActionResult Index()
        {
            var reqModels = _requestRepo.GetAllReqests();
            return View(reqModels);
        }
    }
}
