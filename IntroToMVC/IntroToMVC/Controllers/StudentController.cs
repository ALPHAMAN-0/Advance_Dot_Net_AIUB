using Microsoft.AspNetCore.Mvc;

namespace IntroToMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.StudentModel student)
        {
            if (ModelState.IsValid)
            {
                return View("Details", student);
            }
            return View(student);
        }

        public IActionResult Details(int id)
        {
            var student = new Models.StudentModel()
            {
                id = id,
                name = "John Doe",
                dept = "Computer Science",
                cgpa = 3.8f
            };
            return View(student);
        }
    }
}
