﻿using Microsoft.AspNetCore.Mvc;

namespace PatientRecordManagement.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
