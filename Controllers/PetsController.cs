using System;
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
    public class PetsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Pets
        public ActionResult Index()
        {
            var pets = db.Pets.Include(p => p.vet);
            return View(pets.ToList());
        }

        // GET: Pets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pets pets = db.Pets.Find(id);
            if (pets == null)
            {
                return HttpNotFound();
            }
            return View(pets);
        }

        // GET: Pets/Create
        public ActionResult Create()
        {
            ViewBag.vetId = new SelectList(db.Vet, "vetId", "vetId");
            return View();
        }

        // POST: Pets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "petsId,petName,vetId,description")] Pets pets)
        {
            if (ModelState.IsValid)
            {
                db.Pets.Add(pets);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.vetId = new SelectList(db.Vet, "vetId", "vetId", pets.vetId);
            return View(pets);
        }

        // GET: Pets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pets pets = db.Pets.Find(id);
            if (pets == null)
            {
                return HttpNotFound();
            }
            ViewBag.vetId = new SelectList(db.Vet, "vetId", "vetId", pets.vetId);
            return View(pets);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "petsId,petName,vetId,description")] Pets pets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pets).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.vetId = new SelectList(db.Vet, "vetId", "vetId", pets.vetId);
            return View(pets);
        }

        // GET: Pets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pets pets = db.Pets.Find(id);
            if (pets == null)
            {
                return HttpNotFound();
            }
            return View(pets);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pets pets = db.Pets.Find(id);
            db.Pets.Remove(pets);
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
