using OneToManyCrudOper.Db;
using OneToManyCrudOper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OneToManyCrudOper.Controllers
{
    public class StudentController : Controller
    {
        OneToManyEntities db = new OneToManyEntities();
        // GET: Student
        public ActionResult Index()
        {
            //var result = db.Students.Join(db.Schools, st => st.SchoolId, sc => sc.Id, (st, sc) => new { Student = st, School = sc }).Select(s => new StudentDto { Id = s.Student.Id,
            //    Name = s.Student.Name, SchoolId = s.School.Name)
            //});

           return View(db.Students.ToList());
        }
        //SchoolDto testc(studet s , School sc)
        //{
        //    return new SchoolDto { school = sc, student = st };
        //}
        public ActionResult Create()
        {
             List<SelectListItem> schools = new List<SelectListItem>();
             foreach (var school in db.Schools)
             {
                 //var sli = ;
                 schools.Add(new SelectListItem()
                 {
                     Text = school.Name,
                     Value = school.Id.ToString()
                 });
             }
             ViewBag.Schools = schools;
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDto student)
        {
            if(ModelState.IsValid)
            {
                var studentEntity = new Student
                {
                    Name = student.Name,
                    SchoolId = student.SchoolId
                };
                db.Students.Add(studentEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        public ActionResult Edit(int id)
        {
            Student st = db.Students.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }
            List<SelectListItem> schools = new List<SelectListItem>();
            foreach (var school in db.Schools)
            {
                //var sli = ;
                schools.Add(new SelectListItem()
                {
                    Text = school.Name,
                    Value = school.Id.ToString()
                });
            }
            ViewBag.Schools = schools;
            var std = new StudentDto
            {
                Name = st.Name
            };
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(StudentDto studentDto)
        {
            if (ModelState.IsValid)
            {
                var std = db.Students.Find(studentDto.Id);
                std.Name = studentDto.Name;
                std.SchoolId = studentDto.SchoolId;
                db.Entry(std).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        public ActionResult Delete(int id)
        {
            Student st = db.Students.Find(id);
            if (st == null)
            {
                return HttpNotFound();
            }
            db.Students.Remove(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}