using StudentMvc.Db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentMvc.Models;

namespace StudentMvc.Controllers
{
    public class StudentsController : Controller
    {
        private MaheerEntities db = new MaheerEntities();
        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
            
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student std = db.Students.Find(id);
            if (std == null)
            {
                return HttpNotFound();
            }
            return View(std);
        }        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDto student)
        {
            if (ModelState.IsValid)// studentEntity != null && !string.IsNullOrWhiteSpace(studentEntity.Name))
            {
                var studentEntity = new Student
                {
                    Name = student.Name,
                    Seat_no = student.Seat_no,
                    Year = student.Year,
                    Address = student.Address,
                    Department_Name = student.Department_Name
                };
                db.Students.Add(studentEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadGateway);
            }
            Student stdedit = db.Students.Find(id);
            if(stdedit==null)
            {
                return HttpNotFound();
            }
            var student = new StudentDto
            {
                Id = stdedit.Id,
                Name=stdedit.Name,
                Seat_no=stdedit.Seat_no,
                Year=stdedit.Year,
                Department_Name=stdedit.Department_Name,
                Address=stdedit.Address
                
            };
            return View(stdedit);
        }

        [HttpPost]
        public ActionResult Edit(StudentDto std)
        {
            if(ModelState.IsValid)//(std != null && !string.IsNullOrWhiteSpace(std.Name))
            {
                var updatedStd = db.Students.Find(std.Id);
                updatedStd.Name = std.Name;
                updatedStd.Seat_no = std.Seat_no;
                updatedStd.Year = std.Year;
                updatedStd.Address = std.Address;
                updatedStd.Department_Name = std.Department_Name;
                
                db.Students.Add(updatedStd);
                db.Entry(updatedStd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //var s = db.Students.Find(std.Id);
            return View();
           
        }
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student std = db.Students.Find(id);
            if (std == null)
            {
                return HttpNotFound();
            }

            db.Students.Remove(std);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}