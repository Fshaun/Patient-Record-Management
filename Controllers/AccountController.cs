using Microsoft.AspNetCore.Mvc;

namespace PatientRecordManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
