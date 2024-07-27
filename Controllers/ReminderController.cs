using Microsoft.AspNetCore.Mvc;

namespace PatientRecordManagement.Controllers
{
    public class ReminderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
