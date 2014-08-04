using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Services.Interfaces;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _service;

        public HomeController(IEmployeeService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
			var users = _service.GetEmployees();
            
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
