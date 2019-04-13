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
    public class SchoolController : Controller
    {
        OneToManyEntities db = new OneToManyEntities();
        
        // GET: School
        public ActionResult Index()
        {
            return View(db.Schools.ToList());
        }

        public ActionResult Create()
        {
            //var ss = db.Schools.Select(school => new SelectListItem() { Text = school.Name, Value = school.Id.ToString() }).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(SchoolDto school)
        {
            if(ModelState.IsValid)
            {
                var schoolEntity = new School //object initializer
                {
                   Name = school.Name
                };
                db.Schools.Add(schoolEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        public ActionResult Edit(int id)
        {
            School s = db.Schools.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            var school = new SchoolDto
            {

                Name = s.Name
            };
            return View(school);
        }
        [HttpPost]
        public ActionResult Edit(SchoolDto school)
        {
            if(ModelState.IsValid)
            {
                var sc = db.Schools.Find(school.Id);
                sc.Name = school.Name;
                db.Entry(sc).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        public ActionResult Delete(int id)
        {           
            School s = db.Schools.Find(id);
            if(s==null)
            {
                return HttpNotFound();
            }
            db.Schools.Remove(s);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}