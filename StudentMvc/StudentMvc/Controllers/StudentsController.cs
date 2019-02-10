using StudentMvc.Db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Create(StudentMvc.Db.Student studentEntity)
        {
            if (studentEntity != null && !string.IsNullOrWhiteSpace(studentEntity.Name))
            {
                db.Students.Add(studentEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }     
        public ActionResult Edit(int id,Student std)
        {
            if (std != null && !string.IsNullOrWhiteSpace(std.Name))
            {
                db.Students.Add(std);
                db.Entry(std).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var s = db.Students.Find(id);
            return View(s);
           
        }
        public ActionResult Delete(int id)
        {
            Student std = db.Students.Find(id);
            if (std != null)
            {
                db.Students.Remove(std);
                db.SaveChanges();
            }
                
            return RedirectToAction("Index");
        }
    }
}