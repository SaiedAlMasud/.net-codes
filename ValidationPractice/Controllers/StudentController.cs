using Microsoft.AspNetCore.Mvc;

namespace ValidationPractice.Controllers
{
    public class StudentController : Controller
    {
        EF.ValidationPracticeContext db;
        public StudentController(EF.ValidationPracticeContext _db)
        {
            this.db = _db;
        }
        public IActionResult Index()
        {
            var students = db.Students.ToList();
            return View(students);
        }
    }
}
