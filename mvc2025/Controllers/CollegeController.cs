using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static mvc2025.Models.College;

namespace mvc2025.Controllers
{
    public class CollegeController : Controller
    {

        private static readonly List<student> studList = new List<student>
        {
            new student{
               student_no = "1",
                name="River",
                course="BSCS",
                address="taytay",
                
                subjects = new List<Subjects>
                {

                    new Subjects{
                    subjectCode="1",
                    subjectName="Intro to prog",
                    day="mon",
                    time="5:00"
                    
                    
                    },
                          new Subjects{
                    subjectCode="2",
                    subjectName="Intro to fight",
                    day="tues",
                    time="2:00"


                    },
                                new Subjects{
                    subjectCode="3",
                    subjectName="Intro to sleep",
                    day="wed",
                    time="7:00"


                    }



                }
            },

                 new student{
               student_no = "2",
                name="River2",
                course="BSCS2",
                address="taytay2"
            },

                      new student{
               student_no = "3",
                name="River3",
                course="BSCS3",
                address="taytay3"
            }

        };
        // GET: College
        public ActionResult Index()
        {

            List<student> List = new List<student>();
            List.Add(new student
            {

                student_no = "1",
                name="River",
                course="BSCS",
                address="taytay"

            }); ;

            List.Add(new student
            {

                student_no = "2",
                name = "River2",
                course = "BSCS2",
                address = "taytay2"

            }); ;
            return View(studList);
        }

        [HttpGet]
        public ActionResult addStudent() {
            student studentz = new student();
            return View(studentz);
        }

        public ActionResult editStudent(string student_no)
        {
            if (!string.IsNullOrEmpty(student_no))// Ensure student_no is not null or empty
            {
                student selectedStudent= studList.Where(x => x.student_no == student_no).FirstOrDefault();

                return View(selectedStudent);
            }
            return RedirectToAction("Index");

        }


      
        [HttpPost]

        public ActionResult editStudent(student model)
        {
            if (!string.IsNullOrEmpty(model.student_no))// Ensure student_no is not null or empty
            {
                studList.RemoveAll(x => x.student_no == model.student_no);
                studList.Add(new student
                {
                    student_no = model.student_no,
                    name = model.name,
                    course = model.course,
                    address = model.address
                });

            }
            return RedirectToAction("Index");

        }
        public ActionResult addStudent(student model)
        {
            if (!string.IsNullOrEmpty(model.student_no)) // Ensure student_no is not null or empty
            {
                studList.Add(new student
                {
                    student_no = model.student_no,
                    name = model.name,
                    course = model.course,
                    address = model.address
                });
            }

          
            return RedirectToAction("Index");
        }
    
        public ActionResult deleteStudent(String student_no)
        {
            if (!string.IsNullOrEmpty(student_no))// Ensure student_no is not null or empty
            {
              studList.RemoveAll(x => x.student_no == student_no);
            }

            // Redirect to the Index action after adding the student
            return RedirectToAction("Index");
        }




       
        // GET: College/Details/5
        public ActionResult Details(string student_no)
        {
            if (!string.IsNullOrEmpty(student_no))
            {

                student studeSelect = studList.Where(x => x.student_no == student_no).FirstOrDefault();
                return View(studeSelect);


            }
            return RedirectToAction("Index");
        }

        // GET: College/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: College/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: College/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: College/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: College/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: College/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
