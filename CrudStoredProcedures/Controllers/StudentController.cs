using CrudStoredProcedures.Models;
using CrudStoredProcedures.Service;
using Microsoft.AspNetCore.Mvc;

namespace CrudStoredProcedures.Controllers
{
    public class StudentController : Controller
    {
        IStudentService _studentService = null;

        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public List<Student>GetStudents(string name)
        {
            return _studentService.GetStudents(name);
        }

        public void SaveOrUpdate(Student student)
        {
            _studentService.SaveOrUpdate(student);
        }
        public void Delete(int studentId) 
        {
            _studentService.Delete(studentId);
        }
    }
}
