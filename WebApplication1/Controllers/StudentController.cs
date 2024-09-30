using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using assignment6.context;
using assignment6.context.entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using MimeKit;
using MailKit.Net.Smtp;
using BLL.Services.Abstract;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudnetService _studnetService;
        private readonly IDepartmentService _departmentService;

        public StudentController(ILogger<StudentController> logger, IStudnetService studnetService,IDepartmentService departmentService)
        {
            _logger = logger;
            _studnetService = studnetService;
            this._departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult All()
        {
            var result = from s in _studnetService.GetStudents()
                         select new disStudent { FName = s.Fname, LName = s.Lname, Age = s.Age };
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            StudentVM  student= new StudentVM();
            student.Departments =_departmentService.GetDepartments().ToList();
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

                _studnetService.Add(student);
                
            }
            else
            {
                studentVM.Departments = _departmentService.GetDepartments().ToList();
                return View(studentVM);
            }
            
            
            return RedirectToAction("ALl");
        }


        
        
        
    }
}