﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ds869415MIS4200940.DAL;
using ds869415MIS4200940.Models;

namespace ds869415MIS4200940.Controllers
{
    public class vetsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: vets
        public ActionResult Index()
        {
            return View(db.Vet.ToList());
        }

        // GET: vets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vet vet = db.Vet.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // GET: vets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vetId,firstName,lastName,yearsWorking,patients")] vet vet)
        {
            if (ModelState.IsValid)
            {
                db.Vet.Add(vet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vet);
        }

        // GET: vets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vet vet = db.Vet.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // POST: vets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vetId,firstName,lastName,yearsWorking,patients")] vet vet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vet);
        }

        // GET: vets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vet vet = db.Vet.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // POST: vets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vet vet = db.Vet.Find(id);
            db.Vet.Remove(vet);
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
