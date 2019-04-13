using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using CrudOperByUsingEnFw.Db;
using System.Web;
using System.Web.Mvc;
using CrudOperByUsingEnFw.Models;
using System.Net;

namespace CrudOperByUsingEnFw.Controllers
{
    public class PersonController : Controller
    {
        public void Test(out int result, int num,int num2=1)
        {
            result = num + 2;
            
            //default val,positional par,out par,optional par.
          //  num = num + 2;
            System.Console.WriteLine("Hi");
        }
        CrudOperByUsingEnFwEntities _db = new CrudOperByUsingEnFwEntities();

        // GET: Person
        public ActionResult Index()
        {
            return View(_db.Persons.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PersonDto person)

        {
            if(ModelState.IsValid)
            {
                var personEntity = new Person
                {
                    Name = person.Name,
                    Age = person.Age
                };
                _db.Persons.Add(personEntity);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }    
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Person dbperson = _db.Persons.Find(id);
            if (dbperson == null)
            {
                return HttpNotFound();
            }
            var persondto = new PersonDto
            {
                Id = dbperson.Id,
                Name = dbperson.Name,
                Age = dbperson.Age
            };
            return View(persondto);
        }
        [HttpPost]
        public ActionResult Edit(PersonDto person )
        {

            if(ModelState.IsValid)
            {
                var personentity = _db.Persons.Find(person.Id);
                personentity.Name = person.Name;
                personentity.Age = person.Age;
                _db.Entry(personentity).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Person per = _db.Persons.Find(id);
            if (per == null)
            {
                return HttpNotFound();
            }
                _db.Persons.Remove(per);
                _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}