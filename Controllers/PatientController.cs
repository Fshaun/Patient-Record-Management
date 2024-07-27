using Microsoft.AspNetCore.Mvc;

namespace PatientRecordManagement.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
