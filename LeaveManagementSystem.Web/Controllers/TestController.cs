using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Andrew Wayas",
                DateOfBirth = new DateTime(1972, 04, 28)

            };
            return View(data);
        }
    }
}
