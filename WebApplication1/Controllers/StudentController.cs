using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using assignment6.context;
using assignment6.context.entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly RouteAppContext _routeContext;

        

        public StudentController(ILogger<StudentController> logger, RouteAppContext routeContext)
        {
            _logger = logger;
            _routeContext = routeContext;
        }

        [HttpGet]
        public IActionResult All()
        {
            var result = from s in _routeContext.Students
                         select new disStudent { FName = s.Fname, LName = s.Lname, Age = s.Age };
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            StudentVM  student= new StudentVM();
            student.Departments = _routeContext.Departments.ToList();
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Add(StudentVM studentVM)
        {
            var student = new Student();
            if (ModelState.IsValid)
            {
                student.Address = studentVM.Address;
                student.Fname = studentVM.Fname;
                student.Lname = studentVM.Lname;
                student.DeptId = studentVM.DeptId;
                student.Age = studentVM.Age;

                _routeContext.Add(student);
                await _routeContext.SaveChangesAsync();
            }
            else
            {
                studentVM.Departments = _routeContext.Departments.ToList();
                return View(studentVM);
            }
            

            return RedirectToAction("ALl");
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}