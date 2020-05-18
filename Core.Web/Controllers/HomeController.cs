using Core.IServices;
using Core.Model;
using Core.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Core.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentServices _studentServices;

        public HomeController(ILogger<HomeController> logger, IStudentServices studentServices)
        {
            _logger = logger;
            _studentServices = studentServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Add()
        {
            bool isSuc = _studentServices.Insert(new Student
            {
                Class_ID = 1,
                Name = "chengyb",
                Gender = 1,
                Stu_No = "15130948001"
            });
            return Json(isSuc);
        }
    }
}