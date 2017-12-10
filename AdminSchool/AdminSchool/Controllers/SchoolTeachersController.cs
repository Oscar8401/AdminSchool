using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminSchool.DataAccesslayer;
using AdminSchool.Models;
using PagedList;
using PagedList.Mvc;

namespace AdminSchool.Controllers
{
    public class SchoolTeachersController : Controller
    {
        private SutdentRegisterContext db = new SutdentRegisterContext();

        // GET: SchoolTeachers
        public ActionResult Index(int? page, string searchBy, string search)
        {
            //if (string.IsNullOrEmpty(search))
            //{
            //    return (db.Schoolteachers.ToList().ToPagedList(page ?? 1, 2));
            //}

            if (searchBy == "FirstName")
            {
                return View(db.Schoolteachers.Where(x => x.FirstName == search ||  search == null).ToList().ToPagedList(page ?? 1, 2));
            }
            else if(searchBy == "LastName")
            {
                return View(db.Schoolteachers.Where(x => x.LastName == search || search == null).ToList().ToPagedList(page ?? 1, 2));

            }
            else if (searchBy == "Age")
            {
                return View(db.Schoolteachers.Where(x => x.Age.ToString() == search || search == null).ToList().ToPagedList(page ?? 1, 2));

            }
            else if (searchBy == "Slary")
            {
                return View(db.Schoolteachers.Where(x => x.Salary.ToString() == search || search == null).ToList().ToPagedList(page ?? 1, 2));

            }
            else if(searchBy == "Position")
            {
                return View(db.Schoolteachers.Where(x => x.Position == search || search == null).ToList().ToPagedList(page ?? 1, 2));

            }
            else
            {
                return View(db.Schoolteachers.Where(x => x.FirstName.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 2));

            }
            //return (db.Schoolteachers.ToList().ToPagedList( page ?? 1, 2));


        }

        // GET: SchoolTeachers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolTeacher schoolTeacher = db.Schoolteachers.Find(id);
            if (schoolTeacher == null)
            {
                return HttpNotFound();
            }
            return View(schoolTeacher);
        }

        // GET: SchoolTeachers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolTeachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Age,Salary,FirstName,LastName,Position")] SchoolTeacher schoolTeacher)
        {
            if (ModelState.IsValid)
            {
                db.Schoolteachers.Add(schoolTeacher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schoolTeacher);
        }

        // GET: SchoolTeachers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolTeacher schoolTeacher = db.Schoolteachers.Find(id);
            if (schoolTeacher == null)
            {
                return HttpNotFound();
            }
            return View(schoolTeacher);
        }

        // POST: SchoolTeachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Age,Salary,FirstName,LastName,Position")] SchoolTeacher schoolTeacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schoolTeacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schoolTeacher);
        }

        // GET: SchoolTeachers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolTeacher schoolTeacher = db.Schoolteachers.Find(id);
            if (schoolTeacher == null)
            {
                return HttpNotFound();
            }
            return View(schoolTeacher);
        }

        // POST: SchoolTeachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SchoolTeacher schoolTeacher = db.Schoolteachers.Find(id);
            db.Schoolteachers.Remove(schoolTeacher);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
