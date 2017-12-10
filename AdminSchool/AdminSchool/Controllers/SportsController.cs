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
    public class SportsController : Controller
    {
        private SutdentRegisterContext db = new SutdentRegisterContext();

        // GET: Sports
        public ActionResult Index(int? page, string searchBy, string search)
        {
            if (searchBy == "Football")
            {
                return View(db.Sports.Where(x => x.Football == search || search == null).ToList().ToPagedList(page ?? 1, 2));
            }
            else if (searchBy == "Basketball")
            {
                return View(db.Sports.Where(x => x.Basketball == search ||search == null).ToList().ToPagedList(page ?? 1, 2));
            }
            else if (searchBy == "Ragkpi")
            {
                return View(db.Sports.Where(x => x.Ragkpi == search || search == null).ToList().ToPagedList(page ?? 1, 2));
            }
            else if (searchBy == "Hoky")
            {
                return View(db.Sports.Where(x => x.Hoky == search || search == null).ToList().ToPagedList(page ?? 1, 2));
            }
            else
            {
                return View(db.Sports.Where(x => x.Football.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 2));
            }
            //return View(db.Sports.ToList().ToPagedList(page ?? 1,2));
        }

        // GET: Sports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sport sport = db.Sports.Find(id);
            if (sport == null)
            {
                return HttpNotFound();
            }
            return View(sport);
        }

        // GET: Sports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Football,Basketball,Tennis,Hoky,Ragkpi")] Sport sport)
        {
            if (ModelState.IsValid)
            {
                db.Sports.Add(sport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sport);
        }

        // GET: Sports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sport sport = db.Sports.Find(id);
            if (sport == null)
            {
                return HttpNotFound();
            }
            return View(sport);
        }

        // POST: Sports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Football,Basketball,Tennis,Hoky,Ragkpi")] Sport sport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sport);
        }

        // GET: Sports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sport sport = db.Sports.Find(id);
            if (sport == null)
            {
                return HttpNotFound();
            }
            return View(sport);
        }

        // POST: Sports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sport sport = db.Sports.Find(id);
            db.Sports.Remove(sport);
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
