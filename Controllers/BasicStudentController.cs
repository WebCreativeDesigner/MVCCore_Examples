using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCore_Examples.Models.BasicStudent;

namespace MVCCore_Examples.Controllers
{
    public class BasicStudentController : Controller
    {
        //public IActionResult Index()
        static IList<BasicStudent> studentList = new List<BasicStudent>{
                new BasicStudent() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new BasicStudent() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new BasicStudent() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new BasicStudent() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new BasicStudent() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new BasicStudent() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new BasicStudent() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };
        // GET: Student
        /*public ActionResult Index()
        {
            //fetch students from the DB using Entity Framework here

            return View(studentList);
        }
        */

        // GET: Student
        public ActionResult Index()
        {
            //fetch students from the DB using Entity Framework here

            return View(studentList.OrderBy(s => s.StudentId).ToList());
        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(BasicStudent std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            studentList.Remove(student);
            studentList.Add(std);

            return RedirectToAction("Index");
        }

        /*
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete student from the database whose id matches with specified id

            return RedirectToAction("Index");
        }
        */
    }
}
