﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminSchool.DataAccesslayer;
using AdminSchool.Models;

namespace AdminSchool.Controllers
{
    public class StudentDatasController : Controller
    {
        private SutdentRegisterContext db = new SutdentRegisterContext();

        // GET: StudentDatas
        public ActionResult Index()
        {
            return View(db.StudentDatas.ToList());
        }

        // GET: StudentDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentData studentData = db.StudentDatas.Find(id);
            if (studentData == null)
            {
                return HttpNotFound();
            }
            return View(studentData);
        }

        // GET: StudentDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Age,SchoolClass,FavouritTopic")] StudentData studentData)
        {
            if (ModelState.IsValid)
            {
                db.StudentDatas.Add(studentData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentData);
        }

        // GET: StudentDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentData studentData = db.StudentDatas.Find(id);
            if (studentData == null)
            {
                return HttpNotFound();
            }
            return View(studentData);
        }

        // POST: StudentDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Age,SchoolClass,FavouritTopic")] StudentData studentData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentData);
        }

        // GET: StudentDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentData studentData = db.StudentDatas.Find(id);
            if (studentData == null)
            {
                return HttpNotFound();
            }
            return View(studentData);
        }

        // POST: StudentDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentData studentData = db.StudentDatas.Find(id);
            db.StudentDatas.Remove(studentData);
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
