using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameworkRepository;
using Microsoft.AspNetCore.Mvc;

namespace ntiertest.Controllers
{
    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager(new EfStudentRepository());
        public IActionResult Index()
        {
            var list = studentManager.GetListAll();
            return View(list);
        }
    }
}
