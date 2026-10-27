using Microsoft.AspNetCore.Mvc;

namespace IntroToMVC.Controllers
{
    public class StudentController : Controller
    {
        private static List<Models.StudentModel> students = new List<Models.StudentModel>();
        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Create()          
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.StudentModel student)
        {
            if (ModelState.IsValid)
            {
                student.id = students.Count + 1;   
                students.Add(student);             
                return RedirectToAction("Index");  
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
