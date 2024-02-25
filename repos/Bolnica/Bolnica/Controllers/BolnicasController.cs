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
    public class BolnicasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Bolnicas
        public ActionResult Index()
        {
            return View(db.blnici.ToList());
        }

        // GET: Bolnicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolnicaa bolnica = db.blnici.Find(id);
            if (bolnica == null)
            {
                return HttpNotFound();
            }
            return View(bolnica);
        }

        // GET: Bolnicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bolnicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BolnicaId,Name,Destinacija,imgurl")] Bolnicaa bolnica)
        {
            if (ModelState.IsValid)
            {
                db.blnici.Add(bolnica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bolnica);
        }

        // GET: Bolnicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolnicaa bolnica = db.blnici.Find(id);
            if (bolnica == null)
            {
                return HttpNotFound();
            }
            return View(bolnica);
        }

        // POST: Bolnicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BolnicaId,Name,Destinacija,imgurl")] Bolnicaa bolnica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bolnica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bolnica);
        }

        // GET: Bolnicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolnicaa bolnica = db.blnici.Find(id);
            if (bolnica == null)
            {
                return HttpNotFound();
            }
            return View(bolnica);
        }

        // POST: Bolnicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bolnicaa  bolnica = db.blnici.Find(id);
            db.blnici.Remove(bolnica);
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
