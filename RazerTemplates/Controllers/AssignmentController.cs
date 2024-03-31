using Microsoft.AspNetCore.Mvc;
using RazerTemplates.Models;
using System.Collections.Generic;

namespace RazorTemplates.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index(int accessLevel)
        {
            List<Student> students = GetStudents();

            if (students == null || students.Count == 0)
            {
                return RedirectToAction("Error");
            }

            var viewModel = new AssignmentViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View("~/Views/Home/Index.cshtml", viewModel);
        }

        private List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { FirstName = "Harry", LastName = "Potter", Grade = 85 },
                new Student { FirstName = "Ron", LastName = "Weasley", Grade = 78 },
                new Student { FirstName = "Hermione", LastName = "Granger", Grade = 95 },
                new Student { FirstName = "Neville", LastName = "Longbottom", Grade = 88 },
                new Student { FirstName = "Luna", LastName = "Lovegood", Grade = 92 }

            };
        }
    }
}
