using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bolnica.Models;

namespace Bolnica.Controllers
{
    public class DoktorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Doktors
        public ActionResult Index()
        {
            return View(db.doktori.ToList());
        }

        // GET: Doktors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doktor doktor = db.doktori.Find(id);
            if (doktor == null)
            {
                return HttpNotFound();
            }
            return View(doktor);
        }

        // GET: Doktors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doktors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Sname,Odel")] Doktor doktor)
        {
            if (ModelState.IsValid)
            {
                db.doktori.Add(doktor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doktor);
        }

        // GET: Doktors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doktor doktor = db.doktori.Find(id);
            if (doktor == null)
            {
                return HttpNotFound();
            }
            return View(doktor);
        }

        // POST: Doktors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Sname,Odel")] Doktor doktor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doktor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doktor);
        }

        // GET: Doktors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doktor doktor = db.doktori.Find(id);
            if (doktor == null)
            {
                return HttpNotFound();
            }
            return View(doktor);
        }

        // POST: Doktors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doktor doktor = db.doktori.Find(id);
            db.doktori.Remove(doktor);
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
